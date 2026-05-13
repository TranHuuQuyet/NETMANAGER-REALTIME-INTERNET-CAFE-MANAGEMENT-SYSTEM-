# DOCS Implementation Ready

This is the single startup brief for the team.

## Confirmed Decisions

- `Code/` is the root for all source.
- `Shared` holds DTOs, enums, constants, packet contract, and light parse/serialize helpers.
- `LOGIN` is shared for both admin and client.
- `STATUS` is both heartbeat and state-change update.
- `LOCK` / `UNLOCK` are server-driven; the client executes immediately and returns `ACK` / `STATUS`.
- `CHAT` is 1-1.
- `NOTIFICATION` is message plus light severity.
- Network stability comes before polish.
- UI should stay clean, clear, and runnable from the start.

## Recommended Project Shape

```text
Code/
|-- ServerApp/
|-- ClientApp/
`-- Shared/
DOCS/
|-- API.md
|-- TASKS.md
|-- LEADER_FLOW.md
|-- BUGS.md
`-- members/
```

## What We Build First

1. `Shared` contract and packet helpers.
2. TCP connect / send / receive loop.
3. Login and auth/session flow.
4. `STATUS` heartbeat plus state change sync.
5. `LOCK` / `UNLOCK` with client ACK handling.
6. `NOTIFICATION`, timer, and 1-1 chat.
7. WinForms shell wiring and integration.
8. Reconnect, disconnect, and invalid packet handling.

## Ownership Summary

- Member 1: scope, rules, and integration control
- Member 2: networking core and packet contract
- Member 3: server UI
- Member 4: client UI
- Member 5: auth and session storage
- Member 6: testing and documentation

## Team Rule Set

- One module, one owner.
- One commit, one job.
- Keep packet changes documented in the same session.
- Do not let server and client diverge on schema.
- Keep runtime code inside `Code/`.

## First Sprint Goal

- A client can connect.
- A login packet can round-trip.
- The server can see one client status.
- The client can receive one server command.
- The UI stays responsive.

## Definition of Done for Phase 1

- TCP connection is stable.
- `LOGIN` and `STATUS` are working.
- `LOCK` / `UNLOCK` are wired with ACK flow.
- `NOTIFICATION` and chat are present.
- `Code/` structure is in place.
- The team can continue without guessing ownership.
