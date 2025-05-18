Set objShell = CreateObject("WScript.Shell")
Set objFSO = CreateObject("Scripting.FileSystemObject")

' Get the directory where this script is located
strScriptPath = Replace(WScript.ScriptFullName, WScript.ScriptName, "")

' Function to check if a DLL exists in system directories
Function CheckSystemDLL(dllName)
    Dim systemPaths(3)
    systemPaths(0) = objShell.ExpandEnvironmentStrings("%SystemRoot%\System32\")
    systemPaths(1) = objShell.ExpandEnvironmentStrings("%SystemRoot%\SysWOW64\")
    systemPaths(2) = strScriptPath
    systemPaths(3) = strScriptPath & "xampp\apache\bin\"
    
    For Each path In systemPaths
        If objFSO.FileExists(path & dllName) Then
            CheckSystemDLL = True
            Exit Function
        End If
    Next
    CheckSystemDLL = False
End Function

' Check for required dependencies
If Not CheckSystemDLL("vcruntime140.dll") Then
    MsgBox "Missing required system file: vcruntime140.dll" & vbCrLf & vbCrLf & _
           "Please install Microsoft Visual C++ Redistributable 2015-2022" & vbCrLf & _
           "Download from: https://aka.ms/vs/17/release/vc_redist.x64.exe" & vbCrLf & vbCrLf & _
           "The application will now exit.", vbCritical, "Missing Dependencies"
    
    ' Try to open the download page
    objShell.Run "https://aka.ms/vs/17/release/vc_redist.x64.exe", 1, False
    WScript.Quit(1)
End If

' Function to check if a process is running
Function IsProcessRunning(processName)
    Set objWMIService = GetObject("winmgmts:\\.\root\cimv2")
    Set colProcesses = objWMIService.ExecQuery("SELECT * FROM Win32_Process WHERE Name = '" & processName & "'")
    IsProcessRunning = (colProcesses.Count > 0)
End Function

' Function to check if port is in use
Function IsPortInUse(port)
    On Error Resume Next
    Set objExec = objShell.Exec("netstat -an | findstr :" & port)
    strOutput = objExec.StdOut.ReadAll()
    IsPortInUse = (InStr(strOutput, ":" & port) > 0)
    On Error GoTo 0
End Function

' Function to kill processes using a specific port
Sub KillProcessOnPort(port)
    On Error Resume Next
    ' Find and kill process using the port
    Set objExec = objShell.Exec("netstat -ano | findstr :" & port)
    strOutput = objExec.StdOut.ReadAll()
    If strOutput <> "" Then
        ' Extract PID and kill it
        arrLines = Split(strOutput, vbCrLf)
        For Each line In arrLines
            If InStr(line, "LISTENING") > 0 Then
                arrParts = Split(Trim(line), " ")
                If UBound(arrParts) >= 0 Then
                    strPID = arrParts(UBound(arrParts))
                    objShell.Run "taskkill /F /PID " & strPID, 0, True
                End If
            End If
        Next
    End If
    On Error GoTo 0
End Sub

' Function to kill a process silently
Sub KillProcess(processName)
    On Error Resume Next
    objShell.Run "taskkill /F /IM " & processName, 0, True
    On Error GoTo 0
End Sub

' Function to start Apache with elevated privileges
Sub StartApacheElevated()
    On Error Resume Next
    Dim apacheDir, apacheExe, configFile
    apacheDir = strScriptPath & "xampp\apache\bin\"
    apacheExe = apacheDir & "httpd.exe"
    configFile = strScriptPath & "xampp\apache\conf\httpd.conf"
    
    If objFSO.FileExists(apacheExe) And objFSO.FileExists(configFile) Then
        ' Try to start with elevated privileges
        objShell.Run "PowerShell -Command ""Start-Process -FilePath '" & apacheExe & "' -ArgumentList '-f " & configFile & "' -Verb RunAs -WindowStyle Hidden""", 0, False
    End If
    On Error GoTo 0
End Sub

' Function to start MySQL with elevated privileges
Sub StartMySQLElevated()
    On Error Resume Next
    Dim mysqlDir, mysqlExe, configFile
    mysqlDir = strScriptPath & "xampp\mysql\bin\"
    mysqlExe = mysqlDir & "mysqld.exe"
    configFile = strScriptPath & "xampp\mysql\bin\my.ini"
    
    If objFSO.FileExists(mysqlExe) And objFSO.FileExists(configFile) Then
        ' Try to start with elevated privileges
        objShell.Run "PowerShell -Command ""Start-Process -FilePath '" & mysqlExe & "' -ArgumentList '--defaults-file=" & configFile & " --console' -Verb RunAs -WindowStyle Hidden""", 0, False
    End If
    On Error GoTo 0
End Sub

' Main execution starts here

' Check and resolve port conflicts for Apache (port 80)
If IsPortInUse("80") Then
    KillProcessOnPort "80"
    WScript.Sleep 3000
End If

' Check and resolve port conflicts for MySQL (port 3306)
If IsPortInUse("3306") Then
    KillProcessOnPort "3306"
    WScript.Sleep 3000
End If

' Start Apache if not running
If Not IsProcessRunning("httpd.exe") Then
    KillProcess "httpd.exe"
    WScript.Sleep 2000
    StartApacheElevated
End If

' Start MySQL if not running
If Not IsProcessRunning("mysqld.exe") Then
    KillProcess "mysqld.exe"
    WScript.Sleep 2000
    StartMySQLElevated
End If

' Wait for services to initialize
WScript.Sleep 8000

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