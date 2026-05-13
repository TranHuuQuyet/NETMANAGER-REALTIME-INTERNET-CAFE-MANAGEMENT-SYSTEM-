# TASKS

## Current Priority

1. Create the `Code/ServerApp`, `Code/ClientApp`, and `Code/Shared` source folders.
2. Implement the shared packet contract in `Shared`.
3. Build the TCP connect / send / receive core.
4. Wire shared login, auth, and session flow.
5. Add `STATUS` heartbeat plus state-change updates.
6. Add `LOCK` / `UNLOCK` with client ACK handling.
7. Add `NOTIFICATION`, timer, and 1-1 chat.
8. Connect the WinForms shells to the network layer.
9. Add reconnect, disconnect, and invalid packet handling.

## Done

- MVP scope confirmed.
- Contract order frozen.
- Ownership map confirmed.
- Branch and commit rules confirmed.
- `API.md` published as the shared contract baseline.

## Notes

- Keep this file short.
- Move completed work into code, not into long task history.
- Add new blockers to `BUGS.md`.
