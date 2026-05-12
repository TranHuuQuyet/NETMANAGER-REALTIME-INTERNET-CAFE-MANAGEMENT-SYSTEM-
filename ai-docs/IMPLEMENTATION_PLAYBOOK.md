# IMPLEMENTATION PLAYBOOK

This document turns the 8-week roadmap into an execution plan the team can follow immediately.

It covers:

1. Week-by-week progress by member
2. Day 1 checklist for each member
3. GitHub commit plan to avoid conflicts

## 1. 8-Week Progress Plan By Member

### Phase 1 - Weeks 1-2: Foundation and Contract

#### Member 1 - Team Lead / System Architect

- confirm MVP scope
- freeze folder ownership
- freeze packet list
- confirm branch and commit rules
- write the first version of `API.md`
- make sure no two members touch the same runtime module

#### Member 2 - Network Engineer

- create TCP server skeleton
- create TCP client skeleton
- define JSON framing rule
- define packet serializer and parser
- test one echo message flow
- verify 2 client connections do not break the server

#### Member 3 - Server GUI Developer

- create `ServerApp` project shell
- create dashboard shell
- create login form shell
- create a basic machine list panel
- bind the dashboard to fake data first

#### Member 4 - Client App Developer

- create `ClientApp` project shell
- create connect form shell
- create client login form shell
- create lock screen shell
- bind the client UI to fake data first

#### Member 5 - Database & Authentication

- define SQLite schema for users and sessions
- define password handling rule
- build repository skeleton
- build login validation stub
- document auth flow in docs

#### Member 6 - Tester & Documentation

- create test matrix
- create bug template
- create demo checklist draft
- document how to run the project
- track issues from day one

### Phase 2 - Weeks 3-4: Authentication and Core UI Shells

#### Member 1 - Team Lead / System Architect

- review all packet and state changes
- keep `TASKS.md` and `PROJECT_STATE.md` updated
- resolve module ownership conflicts
- approve contract changes before merge

#### Member 2 - Network Engineer

- connect packet dispatcher to login/status/control messages
- stabilize send and receive loop
- add disconnect handling
- make packet errors fail safely

#### Member 3 - Server GUI Developer

- connect dashboard to auth result
- show machine list from live state
- show online/offline/locked/playing states
- keep UI updates safe on the UI thread

#### Member 4 - Client App Developer

- connect client login to server response
- show connection and auth state
- prepare UI for realtime commands
- keep forms responsive during network activity

#### Member 5 - Database & Authentication

- implement final users and sessions tables
- connect auth to SQLite
- return deterministic login result
- track session start and end

#### Member 6 - Tester & Documentation

- run smoke tests for connect and login
- document bugs with reproduction steps
- update run guide as soon as behavior changes
- verify documentation matches current code

### Phase 3 - Weeks 5-6: Realtime Control Features

#### Member 1 - Team Lead / System Architect

- verify that control features follow the agreed packet contract
- make sure no one adds out-of-scope features
- review integration points before merge

#### Member 2 - Network Engineer

- finish lock / unlock packet flow
- finish notification flow
- finish timer flow
- finish basic chat flow
- support multi-client broadcast where needed

#### Member 3 - Server GUI Developer

- add action buttons for lock, unlock, notification, timer
- render realtime status updates
- make the dashboard feel stable for demo

#### Member 4 - Client App Developer

- implement lock screen behavior
- render timer and notification updates
- implement chat display and send flow
- make sure client reacts to server control commands

#### Member 5 - Database & Authentication

- keep auth/session state aligned with control flow
- support server-side lookup for connected machines
- stabilize data access and persistence

#### Member 6 - Tester & Documentation

- test all realtime control flows
- verify lock/unlock end to end
- verify timer sync end to end
- keep a bug list for every failing flow

### Phase 4 - Weeks 7-8: Stabilization and Demo Readiness

#### Member 1 - Team Lead / System Architect

- approve final scope only
- block new feature creep
- prioritize bug fixes over new work
- confirm demo checklist is complete

#### Member 2 - Network Engineer

- fix invalid packet handling
- fix disconnect and reconnect issues
- improve logging and resilience
- run multi-client network tests

#### Member 3 - Server GUI Developer

- polish dashboard layout
- remove UI clutter
- fix cross-thread issues
- verify dashboard survives reconnect

#### Member 4 - Client App Developer

- polish client screens
- test reconnect behavior
- fix lock screen edge cases
- verify UI does not freeze

#### Member 5 - Database & Authentication

- harden auth and persistence
- fix database error handling
- verify seeded demo accounts

#### Member 6 - Tester & Documentation

- run full regression tests
- write final demo steps
- clean README and usage guide
- confirm final build can be presented

## 2. Day 1 Checklist

### Member 1

- [ ] Confirm the final MVP scope in one paragraph
- [ ] Confirm which features are excluded
- [ ] Confirm ownership for `ServerApp`, `ClientApp`, `Shared`, and `ai-docs`
- [ ] Confirm branch naming and commit naming rules
- [ ] Publish the first version of `API.md` outline

### Member 2

- [ ] Create TCP server listener skeleton
- [ ] Create TCP client connector skeleton
- [ ] Define JSON packet framing
- [ ] Define packet type list
- [ ] Test a basic echo from server to client

### Member 3

- [ ] Create `ServerApp` project shell
- [ ] Create `LoginForm`
- [ ] Create `DashboardForm`
- [ ] Create machine list placeholder
- [ ] Create a fake-data render method

### Member 4

- [ ] Create `ClientApp` project shell
- [ ] Create `ConnectForm`
- [ ] Create `LoginForm`
- [ ] Create `LockForm`
- [ ] Create placeholder areas for timer, chat, and notifications

### Member 5

- [ ] Define `Users` schema
- [ ] Define `Sessions` schema
- [ ] Define password handling rule
- [ ] Create repository skeleton
- [ ] Create login validation stub

### Member 6

- [ ] Create test plan
- [ ] Create bug report template
- [ ] Create demo checklist
- [ ] Document run steps for Windows
- [ ] Start tracking issues immediately

## 3. GitHub Commit Plan

### General Rules

- One commit should do one job.
- One commit should belong to one owner.
- Do not mix UI, networking, and database changes in the same commit if you can avoid it.
- Do not modify another member’s write scope without notifying them.
- If a contract changes, update docs in the same commit or immediately after.

### Branch Strategy

- `main` stays stable.
- Each member works in a feature branch.
- Example branch names:
  - `feature/network-core`
  - `feature/server-ui`
  - `feature/client-ui`
  - `feature/auth-db`
  - `feature/test-docs`

### Suggested Merge Order

1. Merge contract and networking work first.
2. Merge auth and session work next.
3. Merge server UI and client UI after the contract is stable.
4. Merge testing and documentation continuously, not only at the end.

### Commit Order By Phase

#### Phase 1

- commit 1: folder structure and memory docs
- commit 2: shared packet contract
- commit 3: TCP connection skeleton

#### Phase 2

- commit 1: SQLite schema and auth stub
- commit 2: server login and dashboard shell
- commit 3: client connect and login shell

#### Phase 3

- commit 1: lock / unlock flow
- commit 2: timer and notification flow
- commit 3: chat and status sync

#### Phase 4

- commit 1: reconnect and invalid packet handling
- commit 2: UI polish and cross-thread fixes
- commit 3: final docs and demo checklist

### Conflict Avoidance Rules

- Member 2 owns `Shared/Packets` and protocol definitions.
- Member 3 owns server forms and dashboard layout.
- Member 4 owns client forms and lock screen.
- Member 5 owns database and auth services.
- Member 6 owns docs and tests.
- Member 1 owns orchestration, scope, and final review.

If two commits touch the same file, the team should stop and decide who owns that file before continuing.

## 4. Definition Of Ready For Each Phase

Before starting a new phase, the team should confirm:

- the previous phase milestone is complete
- the contract is stable
- the current phase has one clear owner per module
- the bug list is short enough to move on
- the team knows what is not being built

