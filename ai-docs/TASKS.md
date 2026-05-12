# TASKS

## Priorities

1. Freeze the shared contract and ownership map.
2. Start the networking foundation.
3. Add authentication and session tracking.
4. Connect GUI flows to network events.
5. Add persistence and stabilization work.
6. Expand test coverage and demo notes.

## In Progress

- [ ] Introduce actual application source folders
- [ ] Implement the shared packet contract in code
- [ ] Implement TCP server/client connection flow

## Week 1 Freeze

- [x] Confirm MVP scope for the demo-first LAN system
- [x] Confirm the excluded features list
- [x] Confirm ownership for `ServerApp`, `ClientApp`, `Shared`, and `ai-docs`
- [x] Confirm branch naming and commit naming rules
- [x] Publish the first version of `API.md`

## Done This Session

- [x] Freeze the Phase 1 packet order
- [x] Define the v0.1 packet envelope
- [x] Define the v0.1 response pattern
- [x] Capture the Member 1 week 1 control baseline

## Todo

- [ ] Create `ServerApp` project structure
- [ ] Create `ClientApp` project structure
- [ ] Create `Shared` project structure
- [ ] Define packet enums and shared DTOs
- [ ] Implement login/auth flow
- [ ] Implement machine status sync
- [ ] Implement lock/unlock flow
- [ ] Implement timer sync
- [ ] Implement notification flow
- [ ] Implement basic chat flow
- [ ] Add SQLite-backed authentication and session storage
- [ ] Add reconnect and disconnect handling
- [ ] Add integration tests for multi-client scenarios
- [ ] Add bug tracking as implementation begins

## Completed

- [x] Document project vision
- [x] Document architecture intent
- [x] Document team roles
- [x] Document commit and branch conventions
- [x] Create initial project memory files
- [x] Update member role docs for full lifecycle project work
- [x] Create leader-level implementation order guide
- [x] Freeze the Phase 1 Week 1 control docs

## Notes

- Keep the checklist small and current.
- Move items from `Todo` to `Completed` only when the work is truly finished.
- Add newly discovered blockers to `BUGS.md`, not here.
- Week 1 for Member 1 is documentation and contract control only; runtime code stays with the owning module teams.
