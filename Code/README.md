# Code Workspace

This folder is the runtime implementation area for the team.
The workspace is locked for a 3-project implementation shape:

- `ServerApp`
- `ClientApp`
- `Shared`

Project generation is still pending.
This structure only locks folder boundaries, ownership, and source placement.

## Planned Structure

```text
Code/
|-- ServerApp/
|   |-- Forms/
|   |-- Networking/
|   |-- Models/
|   |-- Services/
|   |-- Auth/
|   `-- Database/
|-- ClientApp/
|   |-- Forms/
|   |-- Networking/
|   |-- Models/
|   `-- Services/
`-- Shared/
    |-- Packets/
    |-- Enums/
    |-- Constants/
    `-- Utilities/
```

The following are not part of the intended source tree:

- `.vs/`
- `bin/`
- `obj/`

## Ownership Guide

- `ServerApp/` is mainly for Member 3.
- `ClientApp/` is mainly for Member 4.
- `Shared/` is mainly for Member 2.
- `ServerApp/Auth/` and `ServerApp/Database/` are mainly for Member 5.
- Docs and test notes remain outside this folder in `DOCS/`.

## Working Rule

- Keep packet schemas in `Shared/` stable.
- Keep shared enums in `Shared/Enums/`.
- Keep UI code inside `Forms/`.
- Keep socket logic inside `Networking/`.
- Keep UI-facing orchestration inside `Services/`.
- Keep login, account-to-machine validation, and session rules inside `Auth/`.
- Keep persistence code inside `Database/`.
- Keep app-local display or runtime models inside each app's `Models/`.
- Do not place packet DTOs inside `ServerApp/Models/` or `ClientApp/Models/`.

## Final Notes

- The chosen project baseline is `.NET 8`, C#, WinForms, TCP, SQLite, and `System.Text.Json`.
- `ServerApp` and `ClientApp` will become WinForms projects.
- `Shared` will become a class library.
- Both apps will reference `Shared`.
- No separate `ServerApp.Data` project is planned for v1.
