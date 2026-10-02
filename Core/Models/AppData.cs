using System;
using System.Collections.Generic;

namespace AshkanSocial.Core.Models
{
    [Serializable] public class AppData
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
        public List<NotificationItem> Notifications { get; set; } = new List<NotificationItem>();
        public List<Story> Stories { get; set; } = new List<Story>();
        public List<FriendRequest> FriendRequests { get; set; } = new List<FriendRequest>();
        public List<ReportItem> Reports { get; set; } = new List<ReportItem>();
        public List<ActivityItem> Activities { get; set; } = new List<ActivityItem>();
        public List<DraftPost> Drafts { get; set; } = new List<DraftPost>();
        public List<ScheduledPost> ScheduledPosts { get; set; } = new List<ScheduledPost>();
        public List<Community> Communities { get; set; } = new List<Community>();
        public List<SocialEvent> Events { get; set; } = new List<SocialEvent>();
        public List<Poll> Polls { get; set; } = new List<Poll>();
        public List<PostCollection> Collections { get; set; } = new List<PostCollection>();
        public List<UserSession> Sessions { get; set; } = new List<UserSession>();
        public List<AuditEntry> AuditEntries { get; set; } = new List<AuditEntry>();
        public List<ChatGroup> ChatGroups { get; set; } = new List<ChatGroup>();
        public List<GroupChatMessage> GroupMessages { get; set; } = new List<GroupChatMessage>();
        public List<ConversationDraft> ConversationDrafts { get; set; } = new List<ConversationDraft>();
    }
    [Serializable] public class User
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string AvatarPath { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> FollowingIds { get; set; } = new List<string>();
        public DateTime LastSeenAt { get; set; }
        public List<string> BlockedUserIds { get; set; } = new List<string>();
        public bool PrivateProfile { get; set; }
        public string PreferredLanguage { get; set; } = "en";
        public List<string> MutedConversationUserIds { get; set; } = new List<string>();
        public List<string> PinnedConversationUserIds { get; set; } = new List<string>();
        public List<string> ArchivedConversationUserIds { get; set; } = new List<string>();
        public bool EmailLikeNotifications { get; set; } = true;
        public bool QuietMode { get; set; }
        public string Role { get; set; } = "Member";
        public bool TwoFactorEnabled { get; set; }
        public string RecoveryEmail { get; set; }
    }
    [Serializable] public class Post
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> LikedBy { get; set; } = new List<string>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<string> SavedBy { get; set; } = new List<string>();
        public List<PostReaction> Reactions { get; set; } = new List<PostReaction>();
    }
    [Serializable] public class Story { public string Id { get; set; } public string UserId { get; set; } public string Text { get; set; } public string ImagePath { get; set; } public DateTime CreatedAt { get; set; } }
    [Serializable] public class Comment { public string Id { get; set; } public string UserId { get; set; } public string Text { get; set; } public DateTime CreatedAt { get; set; } public List<CommentReply> Replies { get; set; } = new List<CommentReply>(); }
    [Serializable] public class CommentReply { public string Id { get; set; } public string UserId { get; set; } public string Text { get; set; } public DateTime CreatedAt { get; set; } }
    [Serializable] public class FriendRequest { public string Id { get; set; } public string FromUserId { get; set; } public string ToUserId { get; set; } public string Status { get; set; } public DateTime CreatedAt { get; set; } }
    [Serializable] public class ChatMessage { public string Id { get; set; } public string FromUserId { get; set; } public string ToUserId { get; set; } public string Text { get; set; } public DateTime CreatedAt { get; set; } public bool IsDelivered { get; set; } public bool IsRead { get; set; } public bool IsEdited { get; set; } public string ReplyToMessageId { get; set; } public string Reaction { get; set; } public string AttachmentPath { get; set; } public bool IsForwarded { get; set; } }
    [Serializable] public class PostReaction { public string UserId { get; set; } public string Type { get; set; } }
    [Serializable] public class ReportItem { public string Id { get; set; } public string ReporterUserId { get; set; } public string TargetUserId { get; set; } public string PostId { get; set; } public string Reason { get; set; } public DateTime CreatedAt { get; set; } public string Status { get; set; } }
    [Serializable] public class ActivityItem { public string Id { get; set; } public string UserId { get; set; } public string Action { get; set; } public DateTime CreatedAt { get; set; } }
    [Serializable] public class DraftPost { public string Id { get; set; } public string UserId { get; set; } public string Content { get; set; } public string ImagePath { get; set; } public DateTime UpdatedAt { get; set; } }
    [Serializable] public class ScheduledPost { public string Id { get; set; } public string UserId { get; set; } public string Content { get; set; } public DateTime PublishAt { get; set; } public bool Published { get; set; } }
    [Serializable] public class Community { public string Id { get; set; } public string Name { get; set; } public string Description { get; set; } public string OwnerUserId { get; set; } public DateTime CreatedAt { get; set; } public List<string> MemberUserIds { get; set; } = new List<string>(); }
    [Serializable] public class SocialEvent { public string Id { get; set; } public string Title { get; set; } public string Description { get; set; } public string OwnerUserId { get; set; } public DateTime StartsAt { get; set; } public string Location { get; set; } public List<string> AttendeeUserIds { get; set; } = new List<string>(); }
    [Serializable] public class Poll { public string Id { get; set; } public string UserId { get; set; } public string Question { get; set; } public DateTime CreatedAt { get; set; } public List<PollOption> Options { get; set; } = new List<PollOption>(); }
    [Serializable] public class PollOption { public string Text { get; set; } public List<string> VoterUserIds { get; set; } = new List<string>(); }
    [Serializable] public class PostCollection { public string Id { get; set; } public string UserId { get; set; } public string Name { get; set; } public DateTime CreatedAt { get; set; } public List<string> PostIds { get; set; } = new List<string>(); }
    [Serializable] public class UserSession { public string Id { get; set; } public string UserId { get; set; } public string DeviceName { get; set; } public DateTime CreatedAt { get; set; } public DateTime LastActiveAt { get; set; } public bool Revoked { get; set; } }
    [Serializable] public class AuditEntry { public string Id { get; set; } public string ActorUserId { get; set; } public string Action { get; set; } public string TargetType { get; set; } public string TargetId { get; set; } public DateTime CreatedAt { get; set; } }
    [Serializable] public class ChatGroup { public string Id { get; set; } public string Name { get; set; } public string OwnerUserId { get; set; } public DateTime CreatedAt { get; set; } public string AvatarPath { get; set; } public string Description { get; set; } public List<string> MemberUserIds { get; set; } = new List<string>(); public List<string> AdminUserIds { get; set; } = new List<string>(); }
    [Serializable] public class GroupChatMessage { public string Id { get; set; } public string GroupId { get; set; } public string FromUserId { get; set; } public string Text { get; set; } public DateTime CreatedAt { get; set; } public string AttachmentPath { get; set; } public string Reaction { get; set; } public string ReplyToMessageId { get; set; } }
    [Serializable] public class ConversationDraft { public string UserId { get; set; } public string PeerUserId { get; set; } public string Text { get; set; } public DateTime UpdatedAt { get; set; } }
    [Serializable] public class NotificationItem { public string Id { get; set; } public string UserId { get; set; } public string Text { get; set; } public DateTime CreatedAt { get; set; } public bool IsRead { get; set; } }
}