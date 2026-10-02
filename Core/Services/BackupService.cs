using System;
using System.IO;
namespace AshkanSocial.Core.Services
{
    public sealed class BackupService
    {
        private readonly IDataService _data;
        public BackupService(IDataService data) { if (data == null) throw new ArgumentNullException("data"); _data = data; }
        public void CreateBackup(string destination)
        {
            if (string.IsNullOrWhiteSpace(destination)) throw new ArgumentException("A backup destination is required.", "destination");
            _data.Save();
            if (!File.Exists(_data.DataFilePath)) throw new FileNotFoundException("The Ashkan Social data file was not found.", _data.DataFilePath);
            File.Copy(_data.DataFilePath, destination, true);
            AppLogger.Info("Local backup created: " + destination);
        }
        public void RestoreBackup(string source)
        {
            if (string.IsNullOrWhiteSpace(source) || !File.Exists(source)) throw new FileNotFoundException("The selected backup file was not found.", source);
            // Validate the XML before replacing the live data file.
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Core.Models.AppData));
            using (var stream = File.OpenRead(source)) serializer.Deserialize(stream);
            File.Copy(source, _data.DataFilePath, true);
            AppLogger.Info("Local backup restored from: " + source);
        }
    }
}
