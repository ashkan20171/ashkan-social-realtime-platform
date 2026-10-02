namespace AshkanSocial.RealtimeServer.Contracts;
public sealed record DirectMessageDto(string Id,string FromUserId,string ToUserId,string Text,DateTime CreatedAt);
public sealed record GroupMessageDto(string Id,string GroupId,string FromUserId,string Text,DateTime CreatedAt);
public sealed record TypingDto(string FromUserId,string ToUserId,bool IsTyping);
public sealed record GroupTypingDto(string FromUserId,string GroupId,bool IsTyping);
public sealed record PresenceDto(string UserId,bool IsOnline,DateTime At);
public sealed record NotificationDto(string Id,string UserId,string Text,DateTime CreatedAt);
