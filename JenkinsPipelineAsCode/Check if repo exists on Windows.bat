@echo off

REM cd YOURDIRECTORY

git rev-parse --verify master > nul 2>nul
if %ERRORLEVEL% == 0 (
	echo Branch exits
) else (
	echo Branch does not exit
)

pause