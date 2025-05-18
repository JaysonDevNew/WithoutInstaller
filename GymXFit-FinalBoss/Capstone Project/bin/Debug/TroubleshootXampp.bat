@echo off
echo XAMPP Troubleshooting Utility
echo =============================
cd /d "%~dp0"

echo.
echo Checking system status...
echo.

REM Check if running as administrator
net session >nul 2>&1
if %errorLevel% == 0 (
    echo [OK] Running with Administrator privileges
) else (
    echo [WARNING] Not running as Administrator - some operations may fail
    echo Please run this script as Administrator for best results
)

echo.
echo Checking port availability...

REM Check port 80 (Apache)
netstat -an | findstr :80 >nul
if %errorLevel% == 0 (
    echo [CONFLICT] Port 80 is in use
    echo Processes using port 80:
    for /f "tokens=5" %%a in ('netstat -aon ^| findstr :80') do (
        for /f "tokens=1" %%b in ('tasklist /fi "pid eq %%a" /fo csv 2^>nul ^| findstr /v "INFO:"') do (
            echo   %%b - PID: %%a
        )
    )
    echo.
    set /p "killport80=Kill processes on port 80? (y/n): "
    if /i "!killport80!"=="y" (
        for /f "tokens=5" %%a in ('netstat -aon ^| findstr :80') do (
            taskkill /F /PID %%a >nul 2>&1
        )
        echo Processes killed.
    )
) else (
    echo [OK] Port 80 is available
)

REM Check port 3306 (MySQL)
netstat -an | findstr :3306 >nul
if %errorLevel% == 0 (
    echo [CONFLICT] Port 3306 is in use
    echo Processes using port 3306:
    for /f "tokens=5" %%a in ('netstat -aon ^| findstr :3306') do (
        for /f "tokens=1" %%b in ('tasklist /fi "pid eq %%a" /fo csv 2^>nul ^| findstr /v "INFO:"') do (
            echo   %%b - PID: %%a
        )
    )
    echo.
    set /p "killport3306=Kill processes on port 3306? (y/n): "
    if /i "!killport3306!"=="y" (
        for /f "tokens=5" %%a in ('netstat -aon ^| findstr :3306') do (
            taskkill /F /PID %%a >nul 2>&1
        )
        echo Processes killed.
    )
) else (
    echo [OK] Port 3306 is available
)

echo.
echo Checking XAMPP files...

if exist "xampp\apache\bin\httpd.exe" (
    echo [OK] Apache executable found
) else (
    echo [ERROR] Apache executable not found
)

if exist "xampp\mysql\bin\mysqld.exe" (
    echo [OK] MySQL executable found
) else (
    echo [ERROR] MySQL executable not found
)

if exist "xampp\apache\conf\httpd.conf" (
    echo [OK] Apache config found
    REM Test Apache configuration
    xampp\apache\bin\httpd.exe -t -f "%cd%\xampp\apache\conf\httpd.conf" >nul 2>&1
    if %errorLevel% == 0 (
        echo [OK] Apache configuration is valid
    ) else (
        echo [ERROR] Apache configuration has errors
        echo Running configuration test...
        xampp\apache\bin\httpd.exe -t -f "%cd%\xampp\apache\conf\httpd.conf"
    )
) else (
    echo [ERROR] Apache config not found
)

if exist "xampp\mysql\bin\my.ini" (
    echo [OK] MySQL config found
) else (
    echo [ERROR] MySQL config not found
)

echo.
echo Checking current XAMPP processes...
tasklist | findstr httpd.exe >nul && echo [INFO] Apache is running || echo [INFO] Apache is not running
tasklist | findstr mysqld.exe >nul && echo [INFO] MySQL is running || echo [INFO] MySQL is not running

echo.
echo Options:
echo 1. Fix XAMPP configuration paths
echo 2. Start XAMPP services manually
echo 3. View Apache error log
echo 4. View MySQL error log
echo 5. Exit
echo.
set /p "choice=Enter your choice (1-5): "

if "%choice%"=="1" (
    echo Running configuration fix...
    call FixXamppConfig.bat
) else if "%choice%"=="2" (
    echo Starting services manually...
    echo Starting Apache...
    start /min xampp\apache\bin\httpd.exe
    echo Starting MySQL...
    start /min xampp\mysql\bin\mysqld.exe --defaults-file="%cd%\xampp\mysql\bin\my.ini"
    echo Services started. Check XAMPP Control Panel for status.
) else if "%choice%"=="3" (
    if exist "xampp\apache\logs\error.log" (
        echo Showing last 20 lines of Apache error log:
        echo.
        more +0 "xampp\apache\logs\error.log" | find /v "" | more
    ) else (
        echo Apache error log not found.
    )
) else if "%choice%"=="4" (
    if exist "xampp\mysql\data\*.err" (
        echo Showing MySQL error log:
        echo.
        for %%f in (xampp\mysql\data\*.err) do type "%%f" | more
    ) else (
        echo MySQL error log not found.
    )
)

echo.
pause