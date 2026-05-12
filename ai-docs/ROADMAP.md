# ROADMAP

## Project Vision

NetManager is a LAN-based desktop client-server system for managing internet cafe machines in real time. The project focuses on reliable TCP communication, responsive Windows Forms UIs, and a small but complete demo feature set:

- multi-client connection
- admin dashboard control
- client lock/unlock
- session timer
- realtime notification
- basic chat
- SQLite-backed authentication

The project is intentionally scoped as an MVP first. That means the team should finish the core loop completely before thinking about extra features.

## Delivery Strategy

To maximize the chance of finishing successfully, the team should work in 4 phases, with each phase lasting 2 weeks.

Every phase must end with a usable result, not just partial code.

## 8-Week Plan

### Phase 1 - Weeks 1-2: Foundation and Contract

Goal:

- establish the project structure
- freeze the shared packet contract
- get TCP connection working
- make sure the team can start coding in separate areas without conflict

Must complete:

- `Code/ServerApp`, `Code/ClientApp`, and `Code/Shared` folder structure
- packet contract v0.1
- JSON framing rule
- TCP server and client skeleton
- basic connect / send / receive loop
- one echo test between server and client
- ownership map for all members
- first version of `TASKS.md`, `LEADER_FLOW.md`, and `API.md`

Success criteria:

- server starts and accepts connection
- client connects successfully
- server and client use the same packet format
- no UI work blocks the networking work

Milestone:

- `v0.1-foundation`

### Phase 2 - Weeks 3-4: Authentication and Core UI Shells

Goal:

- make login work
- connect auth to session state
- create the first usable server and client screens

Must complete:

- SQLite schema for users and sessions
- login validation for admin and client
- session tracking
- server login form and dashboard shell
- client connect form and login form
- basic machine list display
- basic client status display
- UI update pattern that does not freeze WinForms

Success criteria:

- admin and client can log in
- server can identify connected machines
- client can show connection and auth state
- UI can render state without cross-thread errors

Milestone:

- `v0.2-auth-ui`

### Phase 3 - Weeks 5-6: Realtime Control Features

Goal:

- implement the actual demo features
- make the system interactive end to end

Must complete:

- machine status sync
- notification flow
- lock / unlock flow
- session timer flow
- basic chat flow
- realtime dashboard updates
- client lock screen
- reconnect and disconnect handling at a basic level

Success criteria:

- admin can control a client machine from the dashboard
- client receives commands in real time
- lock and unlock work correctly
- timer and notification display correctly
- chat messages can move between server and client

Milestone:

- `v0.3-realtime-control`

### Phase 4 - Weeks 7-8: Stabilization, Testing, and Demo Readiness

Goal:

- make the app stable enough to present
- remove major bugs
- finish documentation and demo flow

Must complete:

- multi-client testing
- invalid packet handling
- disconnect and reconnect tests
- logging for network and auth errors
- demo checklist
- run guide
- README cleanup
- bug triage and final fixes

Success criteria:

- 2 to 3 clients can run together on Windows
- the app does not crash under normal demo use
- the team can run the full demo from start to finish
- documentation matches the code

Milestone:

- `v1.0-demo-ready`

## Feature Scope

### Included

- TCP connection
- multi-client support
- realtime machine status
- notification
- lock / unlock
- session timer
- basic chat
- client authentication
- SQLite persistence

### Excluded

- file transfer
- voice call
- video streaming
- complex reporting
- advanced analytics

## Completion Rules

The project should only be considered complete when all of these are true:

- server and client connect reliably
- login works for the expected roles
- core commands work end to end
- UI stays responsive
- multi-client demo passes
- docs and code match
- there is a clear run guide for the team

## Current Phase

Phase 1 - Foundation and Contract.

The next work should focus on the network core, shared packet contract, and project structure before adding heavier GUI or database features.

