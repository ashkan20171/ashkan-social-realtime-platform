# Ashkan Social — Realtime .NET Social Platform

A feature-rich **C#/.NET desktop social platform** combining a premium Windows Forms experience with an **ASP.NET Core SignalR** realtime service.

Ashkan Social is a software-engineering portfolio project focused on desktop product design, realtime architecture, messaging workflows, maintainable service boundaries and transparent engineering trade-offs.

## Highlights
- **Premium desktop UX:** sunset-glass visual system, custom controls, command palette, focus mode and keyboard navigation.
- **Social experience:** feed, posts, comments, reactions, stories, profiles, friends/followers, notifications, bookmarks and media gallery.
- **Direct messaging:** search, unread/archive filters, persistent drafts, replies, reactions, forwarding, attachments, pin/mute and presence/typing integration.
- **Group chat:** group channels, member/admin management, ownership transfer, replies, reactions, shared files and group profiles.
- **Communities:** communities, events, polls and collections.
- **Creator workspace:** Creator Studio, drafts, scheduling/content planning and insights.
- **Trust & governance:** blocking/reporting, privacy workflows, activity/audit views and moderation/admin tooling.
- **Realtime foundation:** SignalR user/group channels, messaging, typing, presence, notifications and delivery acknowledgements.
- **Reliability:** local fallback, outbox foundation, backup/logging and a new Diagnostics Center with report export.
- **Engineering Overview:** an in-app portfolio view summarizing architecture and product scope.

## Architecture
```text
AshkanSocial
├── Core
│   ├── Models
│   └── Services
├── UI
│   ├── Controls
│   └── Forms
└── Assets

AshkanSocial.RealtimeServer
├── Contracts
└── Hubs
```

`IRealtimeClient` separates desktop UI from realtime transport. Local fallback keeps the client usable during offline/local development, while the included ASP.NET Core SignalR service provides the realtime server foundation.

## Tech stack
| Area | Technology |
|---|---|
| Desktop | C#, .NET Framework 4.8, Windows Forms |
| Realtime | ASP.NET Core, SignalR |
| Persistence | XML/local persistence |
| UI | Custom WinForms controls |
| IDE | Visual Studio 2022 |

## Run the desktop app
1. Install Visual Studio 2022 with **.NET desktop development**.
2. Install the **.NET Framework 4.8 Developer Pack**.
3. Open `AshkanSocial.csproj`.
4. Restore required packages.
5. Run **Clean Solution → Rebuild Solution**.
6. Start with `F5`.

## Run the realtime server
```bash
cd AshkanSocial.RealtimeServer
dotnet run --urls http://localhost:5088
```
Health endpoint: `http://localhost:5088/health`

See `SIGNALR-SETUP.md` for integration notes.

## Engineering decisions
**Local-first behavior:** the client remains useful without a realtime server.

**Transport abstraction:** messaging screens depend on `IRealtimeClient`, not a concrete transport.

**Reusable visual system:** shared controls and page helpers maintain a consistent desktop identity.

**Transparent scope:** local attachment paths, local persistence and simulated security/session workflows are documented rather than presented as production cloud security.

## Diagnostics
The Diagnostics Center previews runtime/environment information and can copy or export a support-friendly report. It complements logging, backup and realtime-state infrastructure.

## Keyboard shortcuts
| Shortcut | Action |
|---|---|
| `Ctrl + P` | Command Palette |
| `Ctrl + K` | Explore |
| `Ctrl + M` | Messages |
| `Ctrl + N` | Creator Studio |
| `Ctrl + Shift + F` | Focus Mode |
| `F5` | Refresh Feed |

## Production roadmap
Authenticated SignalR connections · server-side authorization · durable database-backed messaging · secure attachment storage · durable offline retry · unit/integration tests · CI/CD · structured telemetry.

## GitHub presentation
**Recommended repository:** `ashkan-social-realtime-platform`

**Description:** C#/.NET desktop social platform with premium WinForms UX, ASP.NET Core SignalR realtime messaging, group chat, communities, creator tooling, moderation, diagnostics and local-first resilience.

Suggested topics: `csharp`, `dotnet`, `winforms`, `aspnet-core`, `signalr`, `realtime`, `desktop-app`, `social-network`, `software-architecture`, `clean-code`, `ui-ux`, `portfolio-project`.

Use real screenshots from the running application: **Home → Messenger → Group Chat → Communities → Creator Studio/Insights → Security/Admin/Diagnostics**.

## Documentation
`ARCHITECTURE.md` · `SIGNALR-SETUP.md` · `VISUAL-REFERENCE.md` · `BUILD-CHECKLIST.md` · `SECURITY.md` · `CONTRIBUTING.md` · `RECRUITER-NOTES.md`

## Author
**Ashkan Motaei**
"# ashkan-social-realtime-platform" 
