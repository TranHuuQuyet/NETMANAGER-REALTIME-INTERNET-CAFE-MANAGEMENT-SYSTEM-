# DECISIONS

## Important Technical Decisions

- Use TCP sockets for client-server communication.
- Use JSON packets for transport payloads.
- Use Windows Forms for both server and client UIs.
- Use SQLite for lightweight persistence.
- Keep a shared contract project to reduce schema drift.

## Reasons Behind Technology Choices

- TCP is simple, stable, and appropriate for LAN-based realtime control.
- JSON is easy to debug during development and demo sessions.
- Windows Forms is a fast path for desktop UI implementation in C#.
- SQLite keeps the persistence layer local and simple for a class/demo project.
- Shared models reduce the chance of incompatible server/client packet changes.

## Architecture Decisions

- Split the system into `ServerApp`, `ClientApp`, and `Shared`.
- Keep networking logic separate from UI logic.
- Treat packet types as the main contract between modules.
- Prefer simple services and handlers over deeply coupled form logic.
- Keep the feature set limited to core demo flows.

## Constraints and Tradeoffs

- The project prioritizes demo stability over feature breadth.
- Realtime updates require careful thread handling in WinForms.
- JSON over TCP is easier to inspect, but framing and parsing must be handled consistently.
- SQLite is sufficient for this scope, but it is not intended for large-scale concurrent workloads.
- Reconnect support should stay basic until the core flows are stable.

## Stable Conventions

- Keep packet names short and explicit.
- Keep state names consistent between server and client.
- Keep commit messages aligned with the repo commit rule.
- Avoid introducing new architectural layers unless they solve a real problem.

## Phase 1 Week 1 Decisions

- The MVP scope is limited to TCP connection, login, realtime machine status, lock/unlock control, notification delivery, timer updates, and basic chat.
- Out-of-scope items for this project are file transfer, voice call, video streaming, complex reporting, and advanced analytics.
- The shared contract baseline is `API.md` version `v0.1`.
- Packet transport is TCP with UTF-8 JSON and one JSON object per line.
- The frozen packet order for Phase 1 is `LOGIN`, `STATUS`, `LOCK` / `UNLOCK`, `NOTIFICATION`, `TIMER`, `CHAT`.
- Folder ownership is split so each runtime module has a clear owner and Member 1 stays in a coordination role.
- Commit format stays `type(scope): short message` in English.
