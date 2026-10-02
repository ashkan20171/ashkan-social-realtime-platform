using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using AshkanSocial.Core.Models;

namespace AshkanSocial.Core.Services
{
    public sealed class DataService : IDataService
    {
        private static readonly Lazy<DataService> _instance = new Lazy<DataService>(() => new DataService());
        public static DataService Instance { get { return _instance.Value; } }
        private readonly string _folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AshkanSocial");
        private string DataFile { get { return Path.Combine(_folder, "social-data.xml"); } }
        public string DataFilePath { get { return DataFile; } }
        public AppData Data { get; private set; }
        private DataService() { Directory.CreateDirectory(_folder); Load(); Seed(); }
        public void Load()
        {
            try { if(File.Exists(DataFile)) using(var s=File.OpenRead(DataFile)) Data=(AppData)new XmlSerializer(typeof(AppData)).Deserialize(s); }
            catch { Data=null; }
            if(Data==null) Data=new AppData();
            Normalize();
        }
        public void Save()
        {
            Directory.CreateDirectory(_folder); string temp=DataFile+".tmp";
            using(var s=File.Create(temp)) new XmlSerializer(typeof(AppData)).Serialize(s,Data);
            if(File.Exists(DataFile)) File.Delete(DataFile); File.Move(temp,DataFile);
        }

        private void Normalize()
        {
            if(Data.Users==null) Data.Users=new System.Collections.Generic.List<User>();
            if(Data.Posts==null) Data.Posts=new System.Collections.Generic.List<Post>();
            if(Data.Messages==null) Data.Messages=new System.Collections.Generic.List<ChatMessage>();
            if(Data.Notifications==null) Data.Notifications=new System.Collections.Generic.List<NotificationItem>();
            if(Data.Stories==null) Data.Stories=new System.Collections.Generic.List<Story>();
            if(Data.FriendRequests==null) Data.FriendRequests=new System.Collections.Generic.List<FriendRequest>();
            if(Data.Reports==null) Data.Reports=new System.Collections.Generic.List<ReportItem>();
            if(Data.Activities==null) Data.Activities=new System.Collections.Generic.List<ActivityItem>();
            if(Data.Sessions==null) Data.Sessions=new System.Collections.Generic.List<UserSession>();
            if(Data.AuditEntries==null) Data.AuditEntries=new System.Collections.Generic.List<AuditEntry>();
            foreach(var u in Data.Users) { if(u.FollowingIds==null) u.FollowingIds=new System.Collections.Generic.List<string>(); if(u.BlockedUserIds==null) u.BlockedUserIds=new System.Collections.Generic.List<string>(); if(string.IsNullOrWhiteSpace(u.Role)) u.Role="Member"; if(string.Equals(u.Username,"ashkan",StringComparison.OrdinalIgnoreCase)) u.Role="Admin"; }
            foreach(var p in Data.Posts) { if(p.LikedBy==null)p.LikedBy=new System.Collections.Generic.List<string>(); if(p.SavedBy==null)p.SavedBy=new System.Collections.Generic.List<string>(); if(p.Comments==null)p.Comments=new System.Collections.Generic.List<Comment>(); if(p.Reactions==null)p.Reactions=new System.Collections.Generic.List<PostReaction>(); foreach(var c in p.Comments){ if(string.IsNullOrWhiteSpace(c.Id)) c.Id=Guid.NewGuid().ToString(); if(c.Replies==null)c.Replies=new System.Collections.Generic.List<CommentReply>(); } }
        }
        private void Seed()
        {
            if(Data.Users.Count>0) return;
            string h,s; SecurityService.CreatePasswordHash("123456",out h,out s);
            var demo=new User{Id=Guid.NewGuid().ToString(),FullName="Ashkan Motaei",Username="ashkan",Email="ashkan@example.com",PasswordHash=h,PasswordSalt=s,Bio="Software developer · Welcome to Ashkan Social",Location="",CreatedAt=DateTime.Now,Role="Admin",RecoveryEmail="ashkan@example.com"};
            Data.Users.Add(demo);
            Data.Posts.Add(new Post{Id=Guid.NewGuid().ToString(),UserId=demo.Id,Content="Welcome to Ashkan Social! This version includes registration, feed, likes, comments, messaging, search, and profiles.",CreatedAt=DateTime.Now}); Save();
        }
        public User FindLogin(string login) { return Data.Users.FirstOrDefault(u=>string.Equals(u.Username,login,StringComparison.OrdinalIgnoreCase)||string.Equals(u.Email,login,StringComparison.OrdinalIgnoreCase)); }
    }
    public static class Session { public static User CurrentUser { get; set; } }
}