using System;using System.Threading.Tasks;namespace AshkanSocial.Core.Services{
public interface IRealtimeClient:IDisposable{
 RealtimeConnectionState State{get;} event Action<RealtimeConnectionState> StateChanged;event Action<string,string,string> DirectMessageReceived;event Action<string,string,bool> TypingChanged;event Action<string,bool> PresenceChanged;event Action<string,string,string> GroupMessageReceived;event Action<string> NotificationReceived;
 Task ConnectAsync(string userId);Task DisconnectAsync();Task SendDirectMessageAsync(string id,string from,string to,string text);Task SendTypingAsync(string from,string to,bool typing);Task SendGroupMessageAsync(string id,string groupId,string from,string text);Task JoinGroupAsync(string groupId);
}}
