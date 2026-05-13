# TASKS

## 1. Current Project State

Current phase:

- `Phase 0 -> Phase 1`

Current gate target:

- `Gate A - Scope and Contract Gate`

Current reality:

- leader flow da duoc lam lai
- role docs dang duoc dong bo
- chua co runtime implementation bat dau day du

## 2. Immediate Start Tasks

These tasks must be done first before deeper coding:

- [ ] Confirm final source folder structure for `ServerApp`, `ClientApp`, `Shared`, `Data/Auth`.
- [ ] Confirm first accepted version of `DOCS/API.md`.
- [ ] Confirm Week 1 task ownership for all 6 members.
- [ ] Confirm branch naming rule and commit naming rule.
- [ ] Confirm bug report format and test matrix format.

## 3. This Week Priority

### Member 1

- [ ] Freeze MVP and out-of-scope list.
- [ ] Freeze ownership map and write scope boundaries.
- [ ] Freeze first-week tasks and announce owners.
- [ ] Review `API.md` with Member 2 and Member 5.
- [ ] Keep `LEADER_FLOW.md`, `TASKS.md`, and `BUGS.md` aligned.

### Member 2

- [ ] Finalize packet envelope and packet type baseline.
- [ ] Draft serializer/parser rules.
- [ ] Create networking skeleton for server/client communication.
- [ ] Prove first connect/send/receive flow.

### Member 3

- [ ] Create server login shell.
- [ ] Create dashboard shell.
- [ ] Create stub machine list and control area.
- [ ] Bind server UI to service interfaces or placeholders only.

### Member 4

- [ ] Create client connect screen.
- [ ] Create client login shell.
- [ ] Create main client shell.
- [ ] Create lock screen shell.

### Member 5

- [ ] Draft `Users`, `Sessions`, and needed persistence fields.
- [ ] Draft auth result model.
- [ ] Create auth service skeleton.
- [ ] Define session state baseline.

### Member 6

- [ ] Create bug report template.
- [ ] Create test matrix template.
- [ ] Create first checklist for contract and connection tests.
- [ ] Review docs for contradictions.

## 4. Week-by-Week Delivery Targets

### Week 1

Target:

- scope, contract baseline, ownership, and skeleton start are stable

Must be visible by end of week:

- `API.md` baseline
- source folder structure
- networking skeleton
- auth skeleton
- server shell
- client shell
- bug/test templates

### Week 2

Target:

- network core and auth core start working together

Must be visible by end of week:

- TCP listener/connector
- send/receive loop
- repository/auth basics
- login flow baseline
- first real bugs recorded

### Week 3

Target:

- core end-to-end flow works

Must be visible by end of week:

- login -> status -> lock/unlock flow
- dashboard sees machine state
- client reacts to command
- ACK path visible

### Week 4

Target:

- all MVP features exist in real flow

Must be visible by end of week:

- notification
- timer
- chat
- multi-client baseline

### Week 5

Target:

- stabilization and regression

Must be visible by end of week:

- reconnect/disconnect handling
- timeout and invalid packet handling
- bug severity list
- known limitation list

### Week 6

Target:

- release candidate and demo readiness

Must be visible by end of week:

- final smoke test
- clean-machine setup pass
- demo checklist
- final docs aligned with build

## 5. Cross-Member Dependencies

- Member 3 waits on Member 2 for network-facing interface.
- Member 4 waits on Member 2 for client-facing network interface.
- Member 2 waits on Member 5 for auth interface details during login integration.
- Member 3 waits on Member 5 for admin login/auth result behavior.
- Member 4 waits on Member 2 and Member 5 for real client login behavior.
- Member 6 waits on all members for build output, feature status, and bug reproduction.

## 6. Conflict Watch List

These are the most likely overlap areas:

- `DOCS/API.md`: Member 2 edits, Member 1 approves, Member 5 reviews auth/session shape.
- `Shared/`: Member 2 owns packet/runtime shared transport models.
- login flow: Member 2 owns transport path, Member 5 owns auth logic, Member 3/4 own UI response.
- timer state: Member 2 owns transport, Member 5 owns persistence if stored, Member 3/4 own display only.
- README/run guide: Member 6 updates, Member 1 reviews final top-level alignment.

## 7. Weekly Reporting Format

Each member should report in this shape:

- completed
- in progress
- blocked by
- next task
- docs that need update

## 8. Done This Turn

- [x] `LEADER_FLOW.md` restructured into full project execution flow.
- [x] member role docs aligned with the leader flow.
- [x] `TASKS.md` upgraded from short priority list to execution tracker.

## 9. Next Review Checkpoint

Before moving beyond `Gate A`, Member 1 should verify:

- [ ] MVP scope is frozen.
- [ ] ownership is frozen.
- [ ] `API.md` baseline is accepted.
- [ ] Week 1 tasks are accepted by all members.
- [ ] no member is waiting because of unclear responsibility.
