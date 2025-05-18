@echo off
REM Silent startup script for XAMPP services
REM No windows will be shown to the user

REM Set the application directory as the current working directory
cd /d "%~dp0"

REM Function to check if a process is running
:CheckProcess
tasklist /FI "IMAGENAME eq %1" 2>nul | find /I "%1" >nul
exit /b %errorlevel%

REM Silently start Apache if not running
call :CheckProcess httpd.exe
if errorlevel 1 (
    REM Kill any existing Apache processes first
    taskkill /F /IM httpd.exe >nul 2>&1
    
    REM Wait a moment for cleanup
    ping localhost -n 3 >nul
    
    REM Start Apache silently in background
    pushd "%~dp0\xampp\apache\bin"
    start /B "" httpd.exe
    popd
)

REM Silently start MySQL if not running
call :CheckProcess mysqld.exe
if errorlevel 1 (
    REM Kill any existing MySQL processes first
    taskkill /F /IM mysqld.exe >nul 2>&1
    
    REM Wait a moment for cleanup
    ping localhost -n 3 >nul
    
    REM Start MySQL silently in background
    pushd "%~dp0\xampp\mysql\bin"
    start /B "" mysqld.exe --defaults-file="%~dp0\xampp\mysql\bin\my.ini"
    popd
)

REM Wait for services to initialize (silent wait)
ping localhost -n 6 >nul

REM Launch the main application
if exist "Capstone Project.exe" (
    start "" "Capstone Project.exe"
) else (
    REM If exe not found, try with different name
    if exist "CapstoneProject.exe" (
        start "" "CapstoneProject.exe"
    ) else (
        REM Exit silently if application not found
        exit /b 1
    )
)

REM Exit the batch file without showing anything
exit /b 0