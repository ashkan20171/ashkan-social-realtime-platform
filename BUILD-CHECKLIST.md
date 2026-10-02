# Visual Studio Build Checklist
1. Open `AshkanSocial.csproj` in Visual Studio 2022.
2. Ensure `.NET desktop development` and .NET Framework 4.8 Developer Pack are installed.
3. Clean Solution, then Rebuild Solution.
4. The Stage 55 `Image` compile errors are fixed in Stage 56 by importing `System.Drawing` in LoginForm and RegisterForm.
5. CS0067 realtime warnings were cleaned up by giving transport events explicit dispatch paths.
6. Run the desktop app first without the realtime server if you only want to validate UI.
7. Then start `AshkanSocial.RealtimeServer` for realtime development.
