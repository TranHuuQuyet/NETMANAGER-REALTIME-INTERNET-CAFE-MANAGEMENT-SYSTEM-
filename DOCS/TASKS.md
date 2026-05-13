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
- deadline hien tai la 8 tuan
- project uu tien demo chay on dinh truoc

## 2. Immediate Start Tasks

These tasks must be done first before deeper coding:

- [ ] Confirm final source folder structure for `ServerApp`, `ClientApp`, `Shared`, `Data/Auth`.
- [ ] Confirm first accepted version of `DOCS/API.md`.
- [ ] Freeze tech stack: `.NET 8`, C#, WinForms, TCP, SQLite, `System.Text.Json`.
- [ ] Freeze account-per-machine rule with `username <-> machineId`.
- [ ] Freeze supported demo modes: real LAN and local multi-instance.
- [ ] Freeze minimal chat scope: 1-1 text only, no emoji, no history, no file/image.
- [ ] Confirm Week 1 task ownership for all 6 members.
- [ ] Confirm branch naming rule and commit naming rule.
- [ ] Confirm bug report format and test matrix format.

## 3. This Week Priority

### Member 1

- [ ] Freeze MVP and out-of-scope list.
- [ ] Freeze ownership map and write scope boundaries.
- [ ] Freeze stack and identity assumptions.
- [ ] Freeze first-week tasks and announce owners.
- [ ] Review `API.md` with Member 2 and Member 5.
- [ ] Keep `LEADER_FLOW.md`, `TASKS.md`, and `BUGS.md` aligned.

### Member 2

- [ ] Finalize packet envelope and packet type baseline.
- [ ] Draft serializer/parser rules.
- [ ] Create networking skeleton for server/client communication.
- [ ] Prove first connect/send/receive flow.
- [ ] Draft local multi-instance launch assumptions.

### Member 3

- [ ] Create server login shell.
- [ ] Create dashboard shell.
- [ ] Create stub machine list and control area.
- [ ] Bind server UI to service interfaces or placeholders only.
- [ ] Prepare admin login view for `username + password + machineId`.

### Member 4

- [ ] Create client connect screen.
- [ ] Create client login shell.
- [ ] Create main client shell.
- [ ] Create lock screen shell.
- [ ] Prepare client login flow for bound account and machine.

### Member 5

- [ ] Draft `Users`, `Sessions`, and needed persistence fields.
- [ ] Draft auth result model.
- [ ] Create auth service skeleton.
- [ ] Define session state baseline.
- [ ] Draft validation rule for wrong `machineId`.

### Member 6

- [ ] Create bug report template.
- [ ] Create test matrix template.
- [ ] Create first checklist for contract and connection tests.
- [ ] Review docs for contradictions.
- [ ] Create separate checklists for real LAN and local multi-instance demo.

## 4. Week-by-Week Delivery Targets

### Week 1

Target:

- scope, contract baseline, ownership, and skeleton start are stable

Must be visible by end of week:

- `API.md` baseline
- source folder structure
- chosen stack
- identity rule
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

- core control flow is stable

Must be visible by end of week:

- lock/unlock
- ACK visibility
- machine-bound login behavior
- stable admin/client control flow

### Week 5

Target:

- all MVP features exist in real flow

Must be visible by end of week:

- notification
- timer
- chat
- multi-client baseline

### Week 6

Target:

- stabilization and environment validation

Must be visible by end of week:

- reconnect/disconnect handling
- timeout and invalid packet handling
- real LAN smoke test
- local multi-instance smoke test

### Week 7

Target:

- source cleanup, regression, and release candidate

Must be visible by end of week:

- release candidate
- bug severity list
- known limitation list
- cleaned architecture boundaries

### Week 8

Target:

- final demo readiness

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
- All members wait on Member 1 for final stack, scope, and gate approval.

## 6. Conflict Watch List

These are the most likely overlap areas:

- `DOCS/API.md`: Member 2 edits, Member 1 approves, Member 5 reviews auth/session shape.
- `Shared/`: Member 2 owns packet/runtime shared transport models.
- login flow: Member 2 owns transport path, Member 5 owns auth logic, Member 3/4 own UI response.
- timer state: Member 2 owns transport, Member 5 owns persistence if stored, Member 3/4 own display only.
- account-to-`machineId` validation: Member 5 owns validation logic, Member 2 owns transport field path, Member 3/4 own display only.
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
- [ ] tech stack is frozen.
- [ ] account-to-`machineId` rule is frozen.
- [ ] chat scope is frozen.
- [ ] both demo modes are documented.
- [ ] Week 1 tasks are accepted by all members.
- [ ] no member is waiting because of unclear responsibility.
