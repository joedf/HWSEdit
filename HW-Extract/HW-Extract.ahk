#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.
SetBatchLines,-1
;<<<<<<<<  HEADER END  >>>>>>>>>

RevisionDate:="2014/10/17"

Gui, Margin, 7, 7
Gui, Add, Button,x7 y4 gOpen w200, Open...
Gui, Add, Button,xp y+4 gSaveAs wp, Save to...
Gui, Add, Button,xp y+4 gAbout wp, About
Gui, Show, ,HW-Extract
return

GuiClose:
ExitApp

About:
	aTitle:="HW-Extract - Extract Hammerwatch " """" "assets.bin" """"
	MsgBox, 64, %aTitle%, %aTitle%`nBy Joe DF`nRevision Date : %RevisionDate%`nReleased under MIT License
return

Open:
	Gui, +OwnDialogs
	FileSelectFile,assetsFile,3,,Select your Hammerwatch assets file...,Hammerwatch Assets (*.bin)
	if (ErrorLevel) {
		MsgBox No file was selected.
		assetsFile:=""
	} else {
		
	}
return

SaveAs:
	Gui, Submit, NoHide
	;Gui, +OwnDialogs
	Gui, +Disabled
	if StrLen(assetsFile) {
		FileSelectFolder,SaveToDir,,3,Save to Output folder...,
		if (ErrorLevel) {
			MsgBox No folder was selected.
		} else {
			if (pFile := FileOpen(assetsFile,"r")) {
				SplitPath,assetsFile,inFileName
				totalbytes:=pFile.Length
				pTitle:="Extracting files from " """" inFileName """" "..."
				Progress CWFEFEF0 CT111111 CB468847 w400 h64 B1 FS8 WM700 WS700 FM8 ZH12 ZY3 C11, %pTitle%, Reading...
				Progress Show
				pFile.Seek(8)
				while(c:=pFile.ReadUChar()) {
					fn:=pFile.Read(c)
					if InStr(fn,"/") {
						stringReplace,fn,fn,/,\,All
						SplitPath,fn,,fDir
						FileCreateDir,%SaveToDir%\%fDir%
					}
					load_progress(fn,pTitle,pFile.Pos,totalbytes)
					fs:=pFile.ReadUInt()
					pFile.RawRead(tmpBuf,fs)
					Buf2File(SaveToDir . "\" . fn,tmpBuf,fs)
					load_progress(fn,pTitle,pFile.Pos,totalbytes)
				}
				Progress, 100, Done.`n%totalbytes% / %totalbytes% Bytes, %pTitle%
				MsgBox, 4160, , Extraction from "%inFileName%"`nDone!
				Progress, Hide
			} else {
				MsgBox Error : Could not open file.
			}
		}
	} else {
		MsgBox No file was selected.
	}
	Gui, -Disabled
	Gui, Show, ,HW-Extract
return

;############################# Functions ############################################

Buf2File(file,byref buffer,byref size) {
	if (pFile := FileOpen(file,"w")) {
		pFile.Seek(0)
		k:=pFile.RawWrite(buffer,size)
		pFile.Close()
		return k
	}
	return 0
}

load_progress(n,t,c,f) {
	p:=Round((c/f)*100)
	Progress, %p% , Writing "%n%" ...`n%c% / %f% Bytes, %t%
}

