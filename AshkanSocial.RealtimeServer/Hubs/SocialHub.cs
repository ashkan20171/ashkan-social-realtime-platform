using AshkanSocial.RealtimeServer.Contracts;using Microsoft.AspNetCore.SignalR;using System.Collections.Concurrent;
namespace AshkanSocial.RealtimeServer.Hubs;
public sealed class SocialHub:Hub{
 static readonly ConcurrentDictionary<string,string> Connections=new();
 public async Task JoinUser(string userId){Connections[Context.ConnectionId]=userId;await Groups.AddToGroupAsync(Context.ConnectionId,"user:"+userId);await Clients.Others.SendAsync("PresenceChanged",new PresenceDto(userId,true,DateTime.UtcNow));}
 public Task JoinGroup(string groupId)=>Groups.AddToGroupAsync(Context.ConnectionId,"group:"+groupId);
 public Task LeaveGroup(string groupId)=>Groups.RemoveFromGroupAsync(Context.ConnectionId,"group:"+groupId);
 public async Task SendDirectMessage(DirectMessageDto message){await Clients.Group("user:"+message.ToUserId).SendAsync("DirectMessageReceived",message);await Clients.Caller.SendAsync("MessageDelivered",message.Id,message.ToUserId);}
 public async Task SendGroupMessage(GroupMessageDto message){await Clients.OthersInGroup("group:"+message.GroupId).SendAsync("GroupMessageReceived",message);await Clients.Caller.SendAsync("GroupMessageDelivered",message.Id,message.GroupId);}
 public Task Typing(TypingDto state)=>Clients.Group("user:"+state.ToUserId).SendAsync("TypingChanged",state);
 public Task GroupTyping(GroupTypingDto state)=>Clients.OthersInGroup("group:"+state.GroupId).SendAsync("GroupTypingChanged",state);
 public Task MarkRead(string fromUserId,string toUserId,string messageId)=>Clients.Group("user:"+fromUserId).SendAsync("MessageRead",toUserId,messageId);
 public Task PushNotification(NotificationDto notification)=>Clients.Group("user:"+notification.UserId).SendAsync("NotificationReceived",notification);
 public override async Task OnDisconnectedAsync(Exception? ex){if(Connections.TryRemove(Context.ConnectionId,out var userId))await Clients.Others.SendAsync("PresenceChanged",new PresenceDto(userId,false,DateTime.UtcNow));await base.OnDisconnectedAsync(ex);}
}