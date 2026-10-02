using System;
using System.IO;
using System.Text;
namespace AshkanSocial.Core.Services
{
    public static class AppLogger
    {
        private static readonly object Sync = new object();
        private static readonly string Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AshkanSocial", "Logs");
        public static string LogFilePath { get { return Path.Combine(Folder, "ashkan-social.log"); } }
        public static void Info(string message) { Write("INFO", message, null); }
        public static void Error(string message, Exception exception) { Write("ERROR", message, exception); }
        private static void Write(string level, string message, Exception exception)
        {
            try
            {
                lock (Sync)
                {
                    Directory.CreateDirectory(Folder);
                    var sb = new StringBuilder();
                    sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")).Append(" [").Append(level).Append("] ").AppendLine(message ?? string.Empty);
                    if (exception != null) sb.AppendLine(exception.ToString());
                    File.AppendAllText(LogFilePath, sb.ToString());
                }
            }
            catch { }
        }
    }
}
