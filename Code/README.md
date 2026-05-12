# Code Workspace

This folder is the runtime implementation area for the team.

## Planned Structure

```text
Code/
├── ServerApp/
│   ├── Forms/
│   ├── Networking/
│   ├── Models/
│   ├── Services/
│   └── Database/
├── ClientApp/
│   ├── Forms/
│   ├── Networking/
│   ├── Models/
│   └── Services/
└── Shared/
    ├── Packets/
    ├── Constants/
    └── Utilities/
```

## Ownership Guide

- `ServerApp/` is mainly for Member 3.
- `ClientApp/` is mainly for Member 4.
- `Shared/` is mainly for Member 2.
- `Database/` and auth-related server services are mainly for Member 5.
- Docs and test notes remain outside this folder in `ai-docs/` and `DOCX/`.

## Working Rule

- Keep packet schemas in `Shared/` stable.
- Keep UI code inside `Forms/`.
- Keep socket logic inside `Networking/`.
- Keep business logic inside `Services/`.
- Keep persistence code inside `Database/`.

