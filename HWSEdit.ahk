#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.
SetBatchLines,-1
;<<<<<<<<  HEADER END  >>>>>>>>>

RevisionDate:="2014/10/12"

Menu, FileMenu, Add, &Open`tCtrl+O, Open
Menu, FileMenu, Add, &Save As...`tCtrl+S, SaveAs
Menu, FileMenu, Add, E&xit/Cancel`tAlt+F4, GuiClose
Menu, HelpMenu, Add, Help &Topic`tF1, Help
Menu, HelpMenu, Add, &About, About
Menu, MyMenuBar, Add, &File, :FileMenu
Menu, MyMenuBar, Add, &Help, :HelpMenu
Gui, Menu, MyMenuBar

Gui, Margin, 7, 7
Gui, Add, CheckBox,x7 y4 h20 vINetworked, Networked
Gui, Add, CheckBox,ys hp vIInfiniteLives, Infinite Lives
Gui, Add, Text,x7 y+8 w50 hp, Difficulty :
Gui, Add, DDL, x+4 yp-4 w110 vIDifficulty, Easy (0)|Medium (1)||Hard (2)
Gui, Add, Button,x7 y+4 gSaveAs w165, Save As...
Gui, Show, ,HWSEdit
return

GuiClose:
ExitApp

Help:
	run http://google.com
return

About:
	Gui, +OwnDialogs
	MsgBox HWSEdit - Hammerwatch Save Editor`nBy Joe DF`n`nReleased under the MIT License`nRevision Date: %RevisionDate%
return

Open:
	Gui, +OwnDialogs
	FileSelectFile,GameFile,3,,Select your Hammerwatch gamesave file...,Hammerwatch Save (*.hws)
	if (ErrorLevel) {
		MsgBox No file was selected.
		GameFile:=""
	} else {
		
	}
return

SaveAs:
	Gui, Submit, NoHide
	Gui, +OwnDialogs
	if StrLen(GameFile) {
		FileSelectFile,SaveTo,S16,,HWSEdit - Save file as...,Hammerwatch Save (*.hws)
		if (ErrorLevel) {
			MsgBox Save Cancelled.
			return
		}
		SplitPath,SaveTo,,,ext
		if ext != HWS
			SaveTo .= ".hws"
		
		if (File2Buf(GameFile,BUFFER,SIZE)) {
			
			BufPosSet(BUFFER,SIZE,"networked\03",((INetworked==0)?0:1),"UChar",SIZE-64)
			BufPosSet(BUFFER,SIZE,"inflives\03",((IInfiniteLives==0)?0:1),"UChar",SIZE-8000)
			BufPosSet(BUFFER,SIZE,"difficulty\06",(RegExReplace(IDifficulty,"\D")+0),"UInt",SIZE-64)
			
			if !Buf2File(SaveTo,BUFFER,SIZE)
				MsgBox Error : could not write file.
			else
				MsgBox Successfully saved.
		} else {
			MsgBox Error : Could not open file.
		}
		
	} else {
		MsgBox No file was selected.
	}
return

;############################# Functions ############################################

File2Buf(file,byref buffer,byref size) {
	if (pFile := FileOpen(file,"r")) {
		pFile.Seek(0)
		size:=pFile.RawRead(buffer,pFile.Length)
		pFile.Close()
		return size
	}
	return 0
}

Buf2File(file,byref buffer,byref size) {
	if (pFile := FileOpen(file,"w")) {
		pFile.Seek(0)
		k:=pFile.RawWrite(buffer,size)
		pFile.Close()
		return k
	}
	return 0
}

HexArr(string) {
	Arr:=Object(), hex:=0, hexcode:=""
	Loop, Parse, string
	{
		if (hex) {
			hex-=1
			hexcode .= A_loopField
			if (!hex) {
				Arr.Insert(HexStr("0x" hexcode))
			}
		} else {
			if (A_loopField=="\") {
				hexcode:="", hex:=2
			} else {
				Arr.Insert(Asc(A_loopField))
			}
		}
	}
	return Arr
}

HexStr(s) {
	oldFormat := A_FormatInteger
	SetFormat, Integer, Hex
	s:=s+0
	SetFormat, Integer, % oldFormat
	return s + 0	
}

StrPosBuf(ByRef buf,sz,data,start:=0,wlen:=0) {
	d:=HexArr(data)
	m:=d.MaxIndex()
	i:=1
	Loop % sz
	{
		c:=NumGet(&buf,A_Index-1,"UChar")
		if (c==d[i]) {
			if (i==m)
				if (wlen)
					return (A_index)
				else
					return ((A_index) - m)
			i+=1
		} else {
			i:=1
		}
	}
	return 0
}

BufPosSet(Byref BUFFER, SIZE, prefixstring, value, type, start:=0) {
	if (p:=StrPosBuf(BUFFER,SIZE,prefixstring,start,1)) {
		NumPut(value,&BUFFER,p,type)
	}
}

