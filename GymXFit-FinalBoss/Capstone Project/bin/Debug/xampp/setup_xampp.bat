@echo off 
cd /d "%~dp0" 
if exist apache\bin\httpd.exe apache\bin\httpd.exe -t 
if exist mysql\bin\mysqld.exe echo MySQL configuration OK 
pause 
