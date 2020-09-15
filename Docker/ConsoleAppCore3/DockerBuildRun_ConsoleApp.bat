@echo off

docker build -t consoleapp .

docker run -it --rm consoleapp:latest

REM To run the app in linux conainer, use 'dotnet ConsoleApp.dll this is a custom message'