using AshkanSocial.Core.Models;
namespace AshkanSocial.Core.Services
{
    public interface IDataService
    {
        AppData Data { get; }
        string DataFilePath { get; }
        void Load();
        void Save();
        User FindLogin(string login);
    }
}
