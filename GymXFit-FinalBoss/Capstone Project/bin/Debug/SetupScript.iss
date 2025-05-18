[Setup]
AppName=GymXFit
AppVersion=5.0
DefaultDirName={pf}\GymXFit
DefaultGroupName=GymXFit
OutputDir=C:\Users\markj\Videos\GymXFit_V5.0\InstallerOutput
OutputBaseFilename=GymXFitInstaller
Compression=lzma
SolidCompression=yes
; Require admin privileges to install redistributables
PrivilegesRequired=admin

[Files]
; Main application files
Source: "C:\Users\markj\Videos\GymXFit_V5.0\GymXFit-FinalBoss\Capstone Project\bin\Debug\**"; DestDir: "{app}"; Flags: recursesubdirs
; XAMPP portable installation
Source: "C:\Users\markj\Videos\GymXFit_V5.0\GymXFit-FinalBoss\Capstone Project\bin\Debug\xampp\**"; DestDir: "{app}\xampp"; Flags: recursesubdirs
; Silent startup and management scripts
Source: "SilentStartXampp.vbs"; DestDir: "{app}"; Flags: ignoreversion
Source: "ElevatedStartXampp.vbs"; DestDir: "{app}"; Flags: ignoreversion
Source: "SilentStopXampp.vbs"; DestDir: "{app}"; Flags: ignoreversion
Source: "FixXamppConfig.bat"; DestDir: "{app}"; Flags: ignoreversion
Source: "TroubleshootXampp.bat"; DestDir: "{app}"; Flags: ignoreversion
; Visual C++ Redistributable (download from Microsoft)
Source: "redist\vc_redist.x64.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall

[Icons]
Name: "{group}\GymXFit"; Filename: "{app}\ElevatedStartXampp.vbs"; WorkingDir: "{app}"
Name: "{group}\XAMPP Control Panel"; Filename: "{app}\xampp\xampp-control.exe"; WorkingDir: "{app}\xampp"
Name: "{group}\Stop XAMPP Services"; Filename: "{app}\SilentStopXampp.vbs"; WorkingDir: "{app}"
Name: "{group}\Troubleshoot XAMPP"; Filename: "{app}\TroubleshootXampp.bat"; WorkingDir: "{app}"; IconFilename: "{app}\xampp\xampp-control.exe"
Name: "{group}\Fix XAMPP Configuration"; Filename: "{app}\FixXamppConfig.bat"; WorkingDir: "{app}"; IconFilename: "{app}\xampp\xampp-control.exe"

[Run]
; Install Visual C++ Redistributable first
Filename: "{tmp}\vc_redist.x64.exe"; Parameters: "/quiet /norestart"; Description: "Installing Visual C++ Redistributable"; Flags: waituntilterminated
; Configure XAMPP after installation
Filename: "{app}\FixXamppConfig.bat"; Description: "Configure XAMPP paths"; Flags: shellexec runhidden waituntilterminated postinstall
; Optional: Start the application with elevated privileges
Filename: "{app}\ElevatedStartXampp.vbs"; Description: "Launch GymXFit with XAMPP"; Flags: shellexec nowait postinstall skipifsilent

[Code]
function VCRedistNeedsInstall: Boolean;
var
  Version: String;
begin
  // Check if Visual C++ 2015-2022 Redistributable is installed
  if RegQueryStringValue(HKLM, 'SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x64', 'Version', Version) then
    Result := False
  else if RegQueryStringValue(HKLM, 'SOFTWARE\WOW6432Node\Microsoft\VisualStudio\14.0\VC\Runtimes\x64', 'Version', Version) then
    Result := False
  else
    Result := True;
end;

procedure CurStepChanged(CurStep: TSetupStep);
var
  ConfigBat: String;
  CheckScript: String;
begin
  if CurStep = ssPostInstall then
  begin
    // Create configuration batch file
    ConfigBat := ExpandConstant('{app}\configure_xampp.bat');
    SaveStringToFile(ConfigBat, 
      '@echo off' + #13#10 +
      'cd /d "%~dp0"' + #13#10 +
      'echo Configuring XAMPP...' + #13#10 +
      'REM Fix Apache configuration' + #13#10 +
      'if exist "xampp\apache\conf\httpd.conf" (' + #13#10 +
      '  echo Updating Apache configuration...' + #13#10 +
      '  REM Create backup of original config' + #13#10 +
      '  copy "xampp\apache\conf\httpd.conf" "xampp\apache\conf\httpd.conf.backup" >nul' + #13#10 +
      '  REM Replace hardcoded paths with current installation path' + #13#10 +
      '  powershell -Command "(Get-Content xampp\apache\conf\httpd.conf) -replace ''c:/xampp'', ''%~dp0xampp'' | Set-Content xampp\apache\conf\httpd.conf"' + #13#10 +
      ')' + #13#10 +
      'REM Fix MySQL configuration' + #13#10 +
      'if exist "xampp\mysql\bin\my.ini" (' + #13#10 +
      '  echo Updating MySQL configuration...' + #13#10 +
      '  REM Create backup of original config' + #13#10 +
      '  copy "xampp\mysql\bin\my.ini" "xampp\mysql\bin\my.ini.backup" >nul' + #13#10 +
      '  REM Replace hardcoded paths with current installation path' + #13#10 +
      '  powershell -Command "(Get-Content xampp\mysql\bin\my.ini) -replace ''c:/xampp'', ''%~dp0xampp'' | Set-Content xampp\mysql\bin\my.ini"' + #13#10 +
      ')' + #13#10 +
      'echo Configuration complete.' + #13#10, 
      False);

    // Create a script to check for required DLLs
    CheckScript := ExpandConstant('{app}\CheckDependencies.bat');
    SaveStringToFile(CheckScript,
      '@echo off' + #13#10 +
      'echo Checking system dependencies...' + #13#10 +
      'set "MISSING="' + #13#10 +
      '' + #13#10 +
      'REM Check for VCRUNTIME140.dll' + #13#10 +
      'where /q vcruntime140.dll' + #13#10 +
      'if errorlevel 1 (' + #13#10 +
      '  if not exist "%SystemRoot%\System32\vcruntime140.dll" (' + #13#10 +
      '    if not exist "%SystemRoot%\SysWOW64\vcruntime140.dll" (' + #13#10 +
      '      set "MISSING=%MISSING% VCRUNTIME140.dll"' + #13#10 +
      '    )' + #13#10 +
      '  )' + #13#10 +
      ')' + #13#10 +
      '' + #13#10 +
      'if not "%MISSING%"=="" (' + #13#10 +
      '  echo.' + #13#10 +
      '  echo ERROR: Missing required system files:%MISSING%' + #13#10 +
      '  echo.' + #13#10 +
      '  echo Please install Microsoft Visual C++ Redistributable 2015-2022' + #13#10 +
      '  echo Download from: https://aka.ms/vs/17/release/vc_redist.x64.exe' + #13#10 +
      '  echo.' + #13#10 +
      '  pause' + #13#10 +
      '  exit /b 1' + #13#10 +
      ') else (' + #13#10 +
      '  echo All dependencies found!' + #13#10 +
      ')' + #13#10,
      False);
  end;
end;