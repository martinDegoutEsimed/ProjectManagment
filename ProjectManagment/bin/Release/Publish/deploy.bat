@echo off
rem Script by Martin Degout

rem Change this var if not correct
set default_location="C:\Program Files\IIS Express\iisexpress.exe"
set default_port=8080

rem config check
if not exist %default_location% (
    echo IssExpress not found at default location. Maybe you must install it and then rerun this script or run the following command with the iisexpress custom path.
    echo Please run "iisexpress.exe /path:%~dp0"
    pause
    exit /B
)

netstat -o -n -a | findstr ":%default_port%" 
if %ERRORLEVEL% equ 0 (
    echo "Port %default_port% is taken please release it or change default_port variable in this script"
    pause
    exit /B
)


 
rem run server
 %default_location% /path:%~dp0 /port:%default_port%