Set objShell = CreateObject("WScript.Shell")

' Silently stop Apache
objShell.Run "taskkill /F /IM httpd.exe", 0, True

' Silently stop MySQL
objShell.Run "taskkill /F /IM mysqld.exe", 0, True

' Wait a moment for processes to terminate
WScript.Sleep 2000