# NETMANAGER - REALTIME INTERNET CAFE MANAGEMENT SYSTEM

## 1. Project Overview

**Course:** Network Programming  
**Project Type:** Windows desktop client-server application  
**Duration:** 8 weeks  
**Team Size:** 6 members

NetManager is a realtime internet cafe management system built for LAN communication using TCP Socket. The project focuses on multi-client handling, realtime status synchronization, and simple but complete control features for a demo-ready system.

## 2. Main Goal

The team wants to build a stable, demo-ready network programming project with these core capabilities:

- TCP client-server communication
- multi-client connection
- realtime machine status display
- notification delivery
- lock / unlock control
- session timer management
- basic chat
- SQLite-backed authentication

The scope is intentionally small so the project can be finished completely.

## 3. 8-Week Roadmap

The project is split into 4 phases, and each phase lasts 2 weeks.

### Phase 1 - Weeks 1-2: Foundation and Contract

**Goal**

- create the project structure
- freeze the shared packet contract
- build the first TCP connection flow

**Must Complete**

- `Code/ServerApp`, `Code/ClientApp`, `Code/Shared`
- packet contract v0.1
- JSON framing rule
- TCP server skeleton
- TCP client skeleton
- basic send / receive loop
- one echo test
- owner map and task split

**Success Criteria**

- server can accept a client
- client can connect successfully
- both sides use the same packet schema

**Milestone**

- `v0.1-foundation`

### Phase 2 - Weeks 3-4: Authentication and UI Shells

**Goal**

- make login work
- connect auth to session state
- create usable WinForms shells

**Must Complete**

- SQLite schema
- login validation
- session tracking
- server login form
- server dashboard shell
- client connect form
- client login form
- basic machine list and status display

**Success Criteria**

- admin and client can log in
- dashboard shows machine state
- client shows its connection state

**Milestone**

- `v0.2-auth-ui`

### Phase 3 - Weeks 5-6: Realtime Control Features

**Goal**

- implement the main demo features
- make server and client interact in realtime

**Must Complete**

- machine status sync
- notification flow
- lock / unlock flow
- timer sync
- basic chat
- client lock screen
- realtime dashboard update

**Success Criteria**

- admin can control a client machine
- client receives commands in realtime
- lock/unlock works end to end
- timer and notification display correctly

**Milestone**

- `v0.3-realtime-control`

### Phase 4 - Weeks 7-8: Stabilization and Demo Readiness

**Goal**

- fix bugs
- test multi-client scenarios
- finish documentation and demo preparation

**Must Complete**

- reconnect and disconnect handling
- invalid packet handling
- multi-client tests
- network and auth logging
- bug triage
- README cleanup
- demo checklist
- run guide

**Success Criteria**

- 2 to 3 clients can run together on Windows
- the system is stable enough for demo
- documentation matches the actual code

**Milestone**

- `v1.0-demo-ready`

## 4. What Is Included

- TCP communication
- multi-client support
- realtime machine status
- notification
- lock / unlock
- session timer
- basic chat
- client authentication
- SQLite persistence

## 5. What Is Not Included

- file transfer
- voice call
- video streaming
- complex reporting
- advanced analytics

## 6. Final Completion Rule

The project is only considered complete when:

- server and client connect reliably
- login works for the required roles
- control features work end to end
- UI stays responsive
- multi-client demo passes
- docs and code match
- the team can run the demo without extra explanation

## 7. Current Phase

**Current Phase:** Phase 1 - Foundation and Contract

The team should focus on network core, shared contract, and folder structure before moving to GUI and realtime control.

