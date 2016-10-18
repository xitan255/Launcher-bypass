#Region ;**** Directives created by AutoIt3Wrapper_GUI ****
#AutoIt3Wrapper_Icon=..\..\HWCF\XGTA\untitled_y3C_icon.ico
#AutoIt3Wrapper_UseUpx=y
#EndRegion ;**** Directives created by AutoIt3Wrapper_GUI ****
$name = InputBox("Nhập tên tài khoản", "Vui lòng nhập tên tài khoản")
If $name <> "" Then
	POST("http://v-samp.com/?m=launcher&a=play", $name)
    MsgBox(64,"Oh shit!!", "Bypass thành công ! Mời vào phá server :)")
EndIf
Func POST($LINK, $username)
	Local $obj = ObjCreate("WinHttp.WinHttpRequest.5.1")
	If Not IsObj($obj) Then Return "FAIL"
	$obj .Open("POST", $LINK, False)
	If (@error) Then Return SetError(1, 0, 0)
	$obj .SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
	$obj .Send("data=\anim|\audio|\data|\models|\movies|\SAMP|\scripts|\templates|\text|\bass.dll|\eax.dll|\gtaweap3.ttf|\gta_sa.exe|\gta_sa.nfo|\Launcher.exe|\libsquish.dll|\mouse.png|\ogg.dll|\PaulpBaker.COM.PNG|\rcon.exe|\samp-license.txt|\samp.dll|\samp.exe|\samp.saa|\sampaux3.ttf|\sampgui.png|\SAMPUninstall.exe|\samp_debug.exe|\SF Readme.txt|\stream.ini|\trainer.exe|\vorbis.dll|\vorbisFile.dll|\vorbisHooked.dll|&version=0.1&username=" & $username)
	If $obj .Status <> 0x00C8 Then
		MsgBox(16, "", "An Error was found. Code: C_3 - Can't connect to v-samp.com")
	EndIf
	$text = BinaryToString($obj .ResponseBody, 4)
	Return $text
EndFunc   ;==>POST
;MsgBox(16,"Oh shit!!", "No more disk space." & @CRLF & "Delete windows ?")