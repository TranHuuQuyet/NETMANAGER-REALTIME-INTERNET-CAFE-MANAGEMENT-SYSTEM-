# LEADER FLOW

## 1. Purpose

This document is the execution guide for the team lead / system architect.
It defines how to start the project from zero, how to assign work, which module must be finished first, and how to keep the team aligned while building the system.

The goal is to make the project:

- easy to start from scratch
- safe from scope creep
- clear in ownership
- stable in integration
- ready for demo by the end of implementation

## 2. Core Leadership Rules

- Lock scope before polishing UI.
- Lock the shared contract before deep implementation.
- Build networking first, then auth/session, then GUI, then integration.
- Never allow server and client to invent different packet formats.
- Every packet/state change must be reflected in docs the same day.
- Do not let two members edit the same module without a clear owner.
- Prefer a small working version over a large unfinished version.

## 2.1 Phase 1 Week 1 Freeze

This is the baseline that Member 1 should confirm first.

### MVP Scope

The MVP is a LAN-based Windows Forms client-server system for an internet cafe demo.
It must support TCP connection, login, realtime machine status, lock/unlock control, notification delivery, timer updates, and basic chat.

### Out of Scope

- file transfer
- voice call
- video streaming
- complex reporting
- advanced analytics

### Ownership Map

- `ServerApp` - Member 3
- `ClientApp` - Member 4
- `Shared` - Member 2
- `DOCS` - Member 1 coordinates the control docs, Member 6 handles test and documentation notes

### Branch and Commit Rules

- Each member works in a feature branch.
- One commit should do one job.
- One commit should belong to one owner.
- Commit format: `type(scope): short message`
- Commit messages must be written in English.

### Frozen Packet Order

1. `LOGIN`
2. `STATUS`
3. `LOCK` / `UNLOCK`
4. `ACK`
5. `NOTIFICATION`
6. `TIMER`
7. `CHAT`

### Expected Output

- `API.md` published as the first version of the shared contract.
- Folder ownership is explicit.
- Scope boundaries are clear.
- No two members touch the same runtime module without a review step.

## 3. Project Start Order

This is the order the team should follow when starting from zero.

### Step 0 - Setup the project control layer

Owner:

- Member 1

Tasks:

- confirm MVP scope
- remove out-of-scope features
- confirm project name
- confirm folder structure
- confirm branch naming rule
- confirm commit naming rule
- confirm documentation files used by the team
- publish the first version of `API.md`

Output:

- one agreed MVP scope
- one agreed folder layout
- one agreed development rule set
- one shared understanding of what is not being built
- one frozen packet list for Phase 1

### Step 1 - Define the shared contract

Owners:

- Member 1 coordinates
- Member 2 implements the packet layer

Tasks:

- define packet types
- define shared DTOs
- define state enums
- define command enums
- define JSON framing and parsing rules
- define success/fail response structure
- define the first version of `API.md`

Required packet order:

1. `LOGIN`
2. `STATUS`
3. `LOCK` / `UNLOCK`
4. `ACK`
5. `NOTIFICATION`
6. `TIMER`
7. `CHAT`

Output:

- server and client read the same schema
- packet format is stable enough for implementation
- no module depends on an undefined message format
- packet contract can be handed to Member 2 for implementation

### Step 2 - Build the networking core

Owner:

- Member 2

Tasks:

- create TCP server listener
- create TCP client connector
- create async send/receive loop
- create packet serializer/parser
- create dispatcher for packet routing
- create connection/session object per client
- test 2 to 3 client connections at the same time

Implementation order:

1. connect
2. handshake/login
3. status update
4. notification broadcast
5. lock/unlock
6. timer
7. chat

Output:

- TCP communication is stable
- packets can go both directions
- UI is not blocked by socket work

### Step 3 - Build authentication and session storage

Owner:

- Member 5

Tasks:

- create SQLite schema
- create repository/data access layer
- create login validation
- create role mapping if needed
- create session tracking
- create basic configuration persistence
- connect auth result to server flow

Implementation order:

1. `Users` schema
2. `Sessions` schema
3. auth service
4. session service
5. server integration

Output:

- admin/client login can be validated
- session state can be saved and read
- the server can trust one source of truth for auth

### Step 4 - Build server dashboard skeleton

Owner:

- Member 3

Tasks:

- create login form
- create dashboard shell
- create machine list view
- create control panel
- create status display area
- create event refresh pattern

Implementation order:

1. layout
2. login
3. machine list
4. status view
5. control buttons
6. realtime refresh

Dependencies:

- packet contract from Member 2
- auth result from Member 5

Output:

- admin can log in
- admin can see machine list
- dashboard can reflect realtime state

### Step 5 - Build client application skeleton

Owner:

- Member 4

Tasks:

- create connect form
- create client login flow
- create main client screen
- create lock screen
- create message/notification view
- create timer display

Implementation order:

1. connect
2. login
3. receive status
4. receive notification
5. receive timer
6. lock/unlock
7. chat

Dependencies:

- packet contract from Member 2
- auth flow from Member 5

Output:

- client can connect and log in
- client can receive commands from server
- client can switch to lock screen when requested

## 4. Ownership Map

### Member 1 - Team Leader / System Architect

Responsible for:

- scope control
- architecture control
- task splitting
- milestone tracking
- integration review
- decision logging

Main responsibility:

- keep the project direction correct and prevent overlap

### Member 2 - Network Engineer

Responsible for:

- TCP communication
- packet framing/parsing
- dispatcher
- multi-client support
- disconnect/reconnect handling

Main responsibility:

- make the client-server communication reliable and shared by all modules

### Member 3 - Server GUI Developer

Responsible for:

- admin login form
- dashboard layout
- machine list
- machine state rendering
- control buttons

Main responsibility:

- make the server usable and realtime for the admin

### Member 4 - Client App Developer

Responsible for:

- connection screen
- client login
- main client UI
- lock screen
- notification/timer/chat UI

Main responsibility:

- make the client receive and display server commands correctly

### Member 5 - Database & Authentication

Responsible for:

- SQLite schema
- login validation
- session storage
- persistence rules

Main responsibility:

- make authentication and stored state reliable

### Member 6 - Tester & Documentation

Responsible for:

- test plan
- bug report
- regression tracking
- README and usage guide
- demo checklist

Main responsibility:

- make the project verifiable, explainable, and demo-ready

## 5. Execution Phases

### Phase 0 - Kickoff

Goal:

- align the team before coding starts

Deliverables:

- MVP scope
- module ownership
- shared contract draft
- branch and commit rules
- first roadmap update
- first API baseline

Checks:

- every member knows their module
- every member knows their dependency
- no one starts coding a private packet format

### Phase 1 - Architecture and contract

Goal:

- make the system shape clear before implementation grows

Deliverables:

- `API.md`
- architecture notes
- packet list
- state enum list
- module folders

Checks:

- server and client share the same contract
- auth and session rules are clear
- state names are consistent

### Phase 2 - Network foundation

Goal:

- prove the system can connect and exchange packets

Deliverables:

- TCP server
- TCP client
- serializer/parser
- basic dispatcher
- multi-client connection test

Checks:

- 2 to 3 clients can connect
- packet send/receive is stable
- UI thread is not blocked

### Phase 3 - Authentication and persistence

Goal:

- make login and session data work end-to-end

Deliverables:

- SQLite schema
- login validation
- session tracking
- auth result flow

Checks:

- login response is deterministic
- invalid login is handled cleanly
- database errors do not crash the app

### Phase 4 - GUI integration

Goal:

- connect real network events to real screens

Deliverables:

- server dashboard
- client UI
- realtime state update
- lock/unlock actions

Checks:

- server actions reach the client
- client state appears on dashboard
- no cross-thread UI errors

### Phase 5 - Realtime features

Goal:

- complete the demo feature set

Deliverables:

- notification
- timer sync
- chat
- lock screen
- status sync

Checks:

- features work in the right order
- commands are visible on both sides
- state stays synchronized

### Phase 6 - Stabilization

Goal:

- make the app safe for demo

Deliverables:

- disconnect handling
- reconnect handling
- invalid packet handling
- logging
- crash reduction

Checks:

- server survives bad input
- client survives disconnect
- demo flow remains stable

### Phase 7 - Testing and release

Goal:

- confirm the system is ready to present

Deliverables:

- test report
- bug list
- final README
- run guide
- demo checklist

Checks:

- core flow works from start to finish
- documentation matches the code
- team can demo without guessing steps

## 6. Initial Sprint Plan

This is the recommended start order for the first implementation sprint.

### Day 1

- Member 1 writes scope, ownership, and rules
- Member 2 defines packet contract draft
- Member 5 defines DB/auth draft
- Member 3 creates dashboard skeleton
- Member 4 creates client skeleton
- Member 6 creates test matrix and bug template

### Day 2-3

- Member 2 implements TCP connect/send/receive
- Member 5 implements SQLite schema and auth service
- Member 3 connects dashboard to stub data
- Member 4 connects client to stub data

### Day 4-5

- Member 2 finalizes packet framing and dispatcher
- Member 5 connects auth to network flow
- Member 3 adds machine status view
- Member 4 adds receive handlers

### Day 6-7

- integrate server and client
- test login
- test status sync
- test notification
- record bugs

## 7. Handoff Rules

### When a module is considered ready to hand off

- interface is stable
- packet names are fixed
- owner has documented expected inputs and outputs
- at least one sample flow is recorded in docs

### What the next member must receive

- file paths owned by the module
- current assumptions
- packet examples
- known limitations
- pending blockers

### What the previous member must not do

- do not keep changing the contract after handoff without informing others
- do not edit another member's write scope casually
- do not merge undocumented packet changes

## 8. Integration Gates

The project should only move to the next stage if the current gate is passed.

### Gate A - Contract gate

Pass conditions:

- packet schema is agreed
- state model is agreed
- shared enums are agreed

### Gate B - Connection gate

Pass conditions:

- server and client can connect
- packets can be exchanged
- no UI freeze occurs

### Gate C - Auth gate

Pass conditions:

- login works
- auth response is stable
- session state is connected

### Gate D - Control gate

Pass conditions:

- lock/unlock works
- notification works
- timer works
- chat works

### Gate E - Demo gate

Pass conditions:

- multi-client test passes
- disconnect test passes
- docs are updated
- demo checklist is ready

## 9. Daily Leader Workflow

Every working day, Member 1 should do this:

1. Check project state files.
2. Review what changed yesterday.
3. Confirm blockers for each member.
4. Confirm whether any packet or state change occurred.
5. Update priority if one module is blocking others.
6. Record decisions in docs.
7. Make sure every member knows the next task.

## 10. Suggested Task Priority

### Highest priority

- Member 2: networking core
- Member 5: authentication and session

### Next priority

- Member 3: server dashboard skeleton
- Member 4: client app skeleton

### Continuous priority

- Member 6: testing and documentation
- Member 1: integration and control

## 11. Definition of Done for the Team

The project is considered done when all of these are true:

- server and client can connect reliably
- login works with the chosen auth flow
- dashboard shows realtime machine state
- client receives lock/unlock, notification, timer, and chat
- multi-client demo works on Windows
- bugs are documented
- README and run guide match the implementation
- the team can explain the architecture clearly during presentation
