using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using AshkanSocial.Core.Services;
using AshkanSocial.UI.Forms;
namespace AshkanSocial
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => HandleFatal("A user-interface error occurred.", e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => AppLogger.Error("Unhandled application-domain exception.", e.ExceptionObject as Exception);
            TaskScheduler.UnobservedTaskException += (s, e) => { AppLogger.Error("Unobserved task exception.", e.Exception); e.SetObserved(); };
            AppLogger.Info("Ashkan Social started.");
            while (true)
            {
                using (var login = new LoginForm()) { if (login.ShowDialog() != DialogResult.OK) break; }
                using (var main = new MainForm()) { if (main.ShowDialog() != DialogResult.Abort) break; }
            }
            AppLogger.Info("Ashkan Social closed.");
        }
        private static void HandleFatal(string message, Exception exception)
        {
            AppLogger.Error(message, exception);
            MessageBox.Show(message + "\r\n\r\nThe error was written to the local application log.", "Ashkan Social", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
