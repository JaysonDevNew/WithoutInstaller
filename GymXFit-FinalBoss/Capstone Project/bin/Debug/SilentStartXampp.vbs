Set objShell = CreateObject("WScript.Shell")
Set objFSO = CreateObject("Scripting.FileSystemObject")

' Get the directory where this script is located
strScriptPath = Replace(WScript.ScriptFullName, WScript.ScriptName, "")

' Function to check if a process is running
Function IsProcessRunning(processName)
    Set objWMIService = GetObject("winmgmts:\\.\root\cimv2")
    Set colProcesses = objWMIService.ExecQuery("SELECT * FROM Win32_Process WHERE Name = '" & processName & "'")
    IsProcessRunning = (colProcesses.Count > 0)
End Function

' Function to kill a process silently
Sub KillProcess(processName)
    On Error Resume Next
    objShell.Run "taskkill /F /IM " & processName, 0, False
    On Error GoTo 0
End Sub

' Function to start a process silently
Sub StartProcess(executable, workingDir, arguments)
    On Error Resume Next
    If arguments <> "" Then
        objShell.Run Chr(34) & workingDir & executable & Chr(34) & " " & arguments, 0, False
    Else
        objShell.Run Chr(34) & workingDir & executable & Chr(34), 0, False
    End If
    On Error GoTo 0
End Sub

' Start Apache if not running
If Not IsProcessRunning("httpd.exe") Then
    KillProcess "httpd.exe"
    WScript.Sleep 2000
    
    Dim apacheDir
    apacheDir = strScriptPath & "xampp\apache\bin\"
    If objFSO.FileExists(apacheDir & "httpd.exe") Then
        StartProcess "httpd.exe", apacheDir, ""
    End If
End If

' Start MySQL if not running
If Not IsProcessRunning("mysqld.exe") Then
    KillProcess "mysqld.exe"
    WScript.Sleep 2000
    
    Dim mysqlDir, mysqlArgs
    mysqlDir = strScriptPath & "xampp\mysql\bin\"
    mysqlArgs = "--defaults-file=" & Chr(34) & strScriptPath & "xampp\mysql\bin\my.ini" & Chr(34)
    
    If objFSO.FileExists(mysqlDir & "mysqld.exe") Then
        StartProcess "mysqld.exe", mysqlDir, mysqlArgs
    End If
End If

' Wait for services to initialize
WScript.Sleep 5000

' Launch the main application
Dim appExe
If objFSO.FileExists(strScriptPath & "Capstone Project.exe") Then
    appExe = strScriptPath & "Capstone Project.exe"
ElseIf objFSO.FileExists(strScriptPath & "CapstoneProject.exe") Then
    appExe = strScriptPath & "CapstoneProject.exe"
End If

If appExe <> "" Then
    objShell.Run Chr(34) & appExe & Chr(34), 1, False
End If