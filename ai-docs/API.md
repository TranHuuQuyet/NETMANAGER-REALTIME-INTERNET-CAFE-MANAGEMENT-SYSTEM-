# API

## Contract Baseline

Version: `v0.1`

This document is the shared contract reference for Phase 1.
Server, client, and shared models must follow this file until the team formally changes the contract.

## Scope

Core packet types in this baseline:

- `LOGIN`
- `STATUS`
- `LOCK`
- `UNLOCK`
- `NOTIFICATION`
- `TIMER`
- `CHAT`

## Transport Rules

- Transport is TCP.
- Payloads are UTF-8 JSON.
- One packet is one JSON object per line.
- Fields are case-sensitive.
- Unknown fields should be ignored for forward compatibility.
- Invalid packets must fail gracefully instead of crashing the app.

## Packet Envelope

All packets use the same envelope shape.

```json
{
  "type": "LOGIN",
  "source": "client01",
  "target": "server",
  "requestId": "req-0001",
  "timestamp": "2026-05-13T10:00:00Z",
  "success": true,
  "message": "optional human readable note",
  "error": {
    "code": "optional_error_code",
    "details": "optional error details"
  },
  "payload": {}
}
```

### Envelope Rules

- `type` is required.
- `source` and `target` help routing and debugging.
- `requestId` is optional but recommended for request/response matching.
- `success` is used on responses.
- `error` is only present when a request fails.
- `payload` contains the packet-specific body.

## Common Response Pattern

Successful response:

```json
{
  "type": "LOGIN",
  "source": "server",
  "target": "client01",
  "requestId": "req-0001",
  "success": true,
  "message": "Login accepted",
  "payload": {}
}
```

Failed response:

```json
{
  "type": "LOGIN",
  "source": "server",
  "target": "client01",
  "requestId": "req-0001",
  "success": false,
  "message": "Login rejected",
  "error": {
    "code": "INVALID_CREDENTIALS",
    "details": "Username or password is not valid"
  },
  "payload": {}
}
```

## Packet Payloads

### `LOGIN`

Used by admin and client login flows.

```json
{
  "username": "client01",
  "password": "123456",
  "role": "Client",
  "machineId": "PC-01"
}
```

### `STATUS`

Used for machine state updates and heartbeat-style sync.

```json
{
  "machineId": "PC-01",
  "machineName": "Computer 01",
  "status": "Online",
  "ipAddress": "192.168.1.10",
  "lastSeen": "2026-05-13T10:00:00Z"
}
```

### `LOCK`

Used to request or notify a lock action.

```json
{
  "machineId": "PC-01",
  "issuedBy": "admin01",
  "reason": "time_expired"
}
```

### `UNLOCK`

Used to request or notify an unlock action.

```json
{
  "machineId": "PC-01",
  "issuedBy": "admin01",
  "reason": "manual_unlock"
}
```

### `NOTIFICATION`

Used to send a simple message to one machine or to all machines.

```json
{
  "message": "Server restart after 10 minutes",
  "severity": "Info",
  "scope": "Broadcast"
}
```

### `TIMER`

Used for session timer updates.

```json
{
  "machineId": "PC-01",
  "remainingSeconds": 1800,
  "startedAt": "2026-05-13T09:30:00Z",
  "expiresAt": "2026-05-13T10:00:00Z"
}
```

### `CHAT`

Used for basic text chat.

```json
{
  "sender": "PC-01",
  "message": "May em bi lag",
  "room": "main"
}
```

## Shared Models

Recommended shared types for the `Shared` project:

- `PacketType`
- `AuthResult`
- `MachineStatus`
- `CommandType`
- `NotificationMessage`
- `ChatMessage`
- `TimerInfo`
- `SessionInfo`
- `ErrorInfo`

## Database Summary

### `Users`

Suggested fields:

- `Id`
- `Username`
- `PasswordHash`
- `Role`
- `MachineId`
- `IsActive`
- `LastLogin`

### `Sessions`

Suggested fields:

- `Id`
- `UserId`
- `MachineId`
- `Status`
- `StartTime`
- `EndTime`

### `Machines`

Suggested fields:

- `Id`
- `MachineName`
- `IpAddress`
- `Status`
- `LastSeen`

## Change Rule

- If a field name, packet shape, or response rule changes, update this file in the same session.
- Do not let server and client drift into different packet schemas.
