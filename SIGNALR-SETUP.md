# SignalR Setup

## Server
Open a terminal in `AshkanSocial.RealtimeServer` and run:

```bash
dotnet run --urls http://localhost:5088
```

Hub endpoint: `http://localhost:5088/hubs/social`

## WinForms client
The desktop project targets .NET Framework 4.8. Install a compatible `Microsoft.AspNetCore.SignalR.Client` package in the WinForms project, then build a client service around `HubConnectionBuilder`.

Recommended event mapping:
- `DirectMessageReceived` → persist message + refresh active conversation + unread badge.
- `TypingChanged` → update typing indicator.
- `MessageRead` → update read receipt.
- `PresenceChanged` → update online/last-seen UI.

Use automatic reconnect where supported and marshal SignalR callbacks back onto the WinForms UI thread before touching controls.

The server is included and runnable in Stage 49; client package wiring is deliberately isolated so the legacy .NET Framework project is not broken by an unverified package version.

## Stage 50 additions
- Group channels: `JoinGroup`, `LeaveGroup`, `SendGroupMessage`, `GroupTyping`.
- Push-style in-app notification event: `NotificationReceived`.
- Presence now maps connection IDs back to joined user IDs on disconnect.
- `/health` endpoint for diagnostics/deployment checks.
- `IRealtimeClient` keeps WinForms UI transport-agnostic; `LocalRealtimeClient` is the safe fallback until the compatible SignalR client NuGet package is wired.
- `run-realtime-server.cmd` starts the demo server on port 5088.

## Stage 51 additions
- `SignalRRealtimeClient` bridge for the legacy WinForms client.
- `RealtimeClientFactory` chooses real SignalR transport only when enabled and the client assembly is available; otherwise it falls back safely.
- MainForm owns the realtime-client lifecycle and disposes it on shutdown.
- The window title can reflect realtime connection state.
- `install-signalr-client.ps1` documents the final NuGet activation step without pinning an unverified package version into the legacy project.

## Stage 52 additions
- Messenger send path now publishes through `IRealtimeClient` when connected.
- Incoming direct-message events persist locally and refresh chat/history UI.
- Typing events are emitted/consumed through the realtime abstraction.
- Presence events update selected-chat status.
- Message status is connection-aware; local fallback remains available.
- Event handlers are detached when the Messages workspace is disposed to avoid duplicate subscriptions.

## Stage 53 additions
- GroupChatForm joins its SignalR group channel on open.
- Group messages publish through `IRealtimeClient` and incoming group events refresh the UI.
- Group realtime subscriptions are removed on form close.
- Server sends `MessageDelivered` and `GroupMessageDelivered` acknowledgements.
- `RealtimeOutbox` provides a transport-neutral foundation for offline queue/retry work in the next stage.
