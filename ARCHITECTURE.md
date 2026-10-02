# Architecture Notes

Ashkan Social uses a legacy-compatible WinForms client and a separate ASP.NET Core realtime service.

## Desktop
Forms depend on `IDataService` and realtime abstractions rather than directly embedding transport concerns. `IRealtimeClient` provides the seam between local fallback and SignalR transport.

## Realtime service
`SocialHub` manages per-user and per-group channels and exposes message, typing, presence, notification and acknowledgement events.

## Reliability direction
Local persistence keeps the desktop usable independently. `RealtimeOutbox` is the next seam for durable retry when the network is unavailable.

## Production evolution
A production deployment should add authenticated hub connections, server-side persistence, authorization, rate limiting, telemetry, secure attachment storage, tests and CI/CD.
