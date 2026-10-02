@echo off
cd /d "%~dp0AshkanSocial.RealtimeServer"
dotnet run --urls http://localhost:5088
pause
