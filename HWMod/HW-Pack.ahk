#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.
SetBatchLines,-1
;<<<<<<<<  HEADER END  >>>>>>>>>

RevisionDate:="2014/10/17"

Gui, Margin, 7, 7
Gui, Add, Button,x7 y4 gOpen w200, Open parent folder...
Gui, Add, Button,xp y+4 gSaveAs wp, Save As *.bin ...
Gui, Add, Button,xp y+4 gAbout wp, About
Gui, Show, ,HW-Pack
return

GuiClose:
ExitApp

About:
	aTitle:="HW-Pack - RePack Hammerwatch " """" "assets.bin" """"
	MsgBox, 64, %aTitle%, %aTitle%`nBy Joe DF`nRevision Date : %RevisionDate%`nReleased under MIT License
return

Open:
	Gui, +OwnDialogs
	FileSelectFolder,PackFromDir,,3,Pack From folder...
	if (ErrorLevel) {
		MsgBox No folder was selected.
		PackFromDir:=""
	} else {
		SetWorkingDir %PackFromDir%
	}
return

SaveAs:
	Gui, Submit, NoHide
	;Gui, +OwnDialogs
	Gui, +Disabled
	if StrLen(PackFromDir) {
		FileSelectFile,assetsFile,S19,,Save your Hammerwatch assets file...,Hammerwatch Assets (*.bin)
		if (ErrorLevel) {
			MsgBox No folder was selected.
		} else if (InStr(assetsFile,PackFromDir)) {
			MsgBox Invalid folder, Please choose a location outside of this folder.
		} else {
			SplitPath,assetsFile,,,ext
			if ext != BIN
				assetsFile .= ".bin"
			
			if (pFile := FileOpen(assetsFile,"w")) {
				pFile.Seek(0)
				SplitPath,assetsFile,inFileName
				totalbytes:=GetFolderSize(PackFromDir)
				pTitle:="Packing files to " """" inFileName """" "..."
				Progress CWFEFEF0 CT111111 CB468847 w400 h64 B1 FS8 WM700 WS700 FM8 ZH12 ZY3 C11, %pTitle%, Reading...
				Progress Show
				HexWrite(pFile,"48 57 52 41 28 09 00 00")
				count_sz:=0
				Loop, %PackFromDir%\*.*, , 1
				{
					fn:=A_LoopFileLongPath
					stringReplace,fn,fn,%PackFromDir%\
					stringReplace,fn,fn,\,/,All
					load_progress(fn,pTitle,count_sz,totalbytes)
					pFile.WriteUChar(StrLen(fn))
					pFile.Write(fn)
					count_sz+=File2Buf(fn,tmpBuf,fs)
					pFile.WriteUInt(fs)
					pFile.RawWrite(tmpBuf,fs)
					load_progress(fn,pTitle,count_sz,totalbytes)
				}
				pFile.Close()
				Progress, 100, Done.`n%totalbytes% / %totalbytes% Bytes, %pTitle%
				MsgBox, 4160, , Packed to "%inFileName%"`nDone!
				Progress, Hide
			} else {
				MsgBox Error : Could not open file.
			}
		}
	} else {
		MsgBox No file was selected.
	}
	Gui, -Disabled
	Gui, Show, ,HW-Pack
return

;############################# Functions ############################################

HexWrite(byref pFile,data) {
	loop, Parse, data, %A_Space%
		pFile.WriteUChar(HexStr("0x" A_LoopField))
}

HexStr(s) {
	oldFormat := A_FormatInteger
	SetFormat, Integer, Hex
	s:=s+0
	SetFormat, Integer, % oldFormat
	return s + 0	
}

File2Buf(file,byref buffer,byref size) {
	if (pFile := FileOpen(file,"r")) {
		pFile.Seek(0)
		size:=pFile.RawRead(buffer,pFile.Length)
		pFile.Close()
		return size
	}
	return 0
}

GetFolderSize(d) {
	Loop, %d%\*.*, , 1
		FolderSize += %A_LoopFileSize%
	return FolderSize
}

load_progress(n,t,c,f) {
	p:=Round((c/f)*100)
	Progress, %p% , Writing "%n%" ...`n%c% / %f% Bytes, %t%
}

