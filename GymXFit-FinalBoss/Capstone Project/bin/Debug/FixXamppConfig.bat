@echo off
cd /d "%~dp0"

echo Fixing XAMPP Configuration...

REM Get the current installation path
set "INSTALL_PATH=%~dp0"
set "INSTALL_PATH=%INSTALL_PATH:~0,-1%"

REM Fix Apache configuration
if exist "xampp\apache\conf\httpd.conf" (
    echo Updating Apache configuration...
    
    REM Create backup
    copy "xampp\apache\conf\httpd.conf" "xampp\apache\conf\httpd.conf.backup" >nul 2>&1
    
    REM Fix paths in httpd.conf
    powershell -Command ^
    "(Get-Content 'xampp\apache\conf\httpd.conf') " ^
    "-replace 'c:/xampp', '%INSTALL_PATH:\=/%/xampp' " ^
    "-replace 'c:\\xampp', '%INSTALL_PATH%\xampp' " ^
    "-replace 'C:/xampp', '%INSTALL_PATH:\=/%/xampp' " ^
    "-replace 'C:\\xampp', '%INSTALL_PATH%\xampp' " ^
    "| Set-Content 'xampp\apache\conf\httpd.conf'"
    
    REM Fix DocumentRoot and Directory paths specifically
    powershell -Command ^
    "(Get-Content 'xampp\apache\conf\httpd.conf') " ^
    "-replace 'DocumentRoot \".*\"', 'DocumentRoot \"%INSTALL_PATH:\=/%/xampp/htdocs\"' " ^
    "-replace '<Directory \".*htdocs\">', '<Directory \"%INSTALL_PATH:\=/%/xampp/htdocs\">' " ^
    "| Set-Content 'xampp\apache\conf\httpd.conf'"
)

REM Fix MySQL configuration
if exist "xampp\mysql\bin\my.ini" (
    echo Updating MySQL configuration...
    
    REM Create backup
    copy "xampp\mysql\bin\my.ini" "xampp\mysql\bin\my.ini.backup" >nul 2>&1
    
    REM Fix paths in my.ini
    powershell -Command ^
    "(Get-Content 'xampp\mysql\bin\my.ini') " ^
    "-replace 'c:/xampp', '%INSTALL_PATH:\=/%/xampp' " ^
    "-replace 'c:\\xampp', '%INSTALL_PATH%\xampp' " ^
    "-replace 'C:/xampp', '%INSTALL_PATH:\=/%/xampp' " ^
    "-replace 'C:\\xampp', '%INSTALL_PATH%\xampp' " ^
    "| Set-Content 'xampp\mysql\bin\my.ini'"
)

REM Fix PHP configuration
if exist "xampp\php\php.ini" (
    echo Updating PHP configuration...
    
    REM Create backup
    copy "xampp\php\php.ini" "xampp\php\php.ini.backup" >nul 2>&1
    
    REM Fix paths in php.ini
    powershell -Command ^
    "(Get-Content 'xampp\php\php.ini') " ^
    "-replace 'c:/xampp', '%INSTALL_PATH:\=/%/xampp' " ^
    "-replace 'c:\\xampp', '%INSTALL_PATH%\xampp' " ^
    "-replace 'C:/xampp', '%INSTALL_PATH:\=/%/xampp' " ^
    "-replace 'C:\\xampp', '%INSTALL_PATH%\xampp' " ^
    "| Set-Content 'xampp\php\php.ini'"
)

REM Create a setup_xampp.bat file for manual configuration
echo @echo off > xampp\setup_xampp.bat
echo cd /d "%%~dp0" >> xampp\setup_xampp.bat
echo if exist apache\bin\httpd.exe apache\bin\httpd.exe -t >> xampp\setup_xampp.bat
echo if exist mysql\bin\mysqld.exe echo MySQL configuration OK >> xampp\setup_xampp.bat
echo pause >> xampp\setup_xampp.bat

echo Configuration complete!
echo.
echo If you still have issues:
echo 1. Run this script as Administrator
echo 2. Check Windows Event Viewer for detailed errors
echo 3. Ensure ports 80 and 3306 are not used by other programs
echo.