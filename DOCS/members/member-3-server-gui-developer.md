# Member 3 - Server GUI Developer

## 1. Vai tro

Ban phu trach giao dien admin cua server.
Muc tieu cua ban la tao dashboard de admin dang nhap, xem trang thai may, va thao tac lock/unlock/notification/timer/chat mot cach ro rang, nhanh, de demo.

## 2. Write Scope

Ban duoc uu tien sua:

- `ServerApp/`
- server-side forms
- server-side views
- server-side UI bridge/services neu can cho UI

Ban khong nen sua:

- packet schema
- socket dispatcher
- client UI
- database/auth internals

## 3. Thu ban so huu

- admin login form
- dashboard shell
- machine list
- machine status rendering
- admin control area
- admin-side realtime display
- UI thread-safe update pattern cho server app

## 4. Dependency cua ban

- packet/service interface tu Member 2
- auth result tu Member 5
- phase order va scope tu Member 1

## 5. Nhiem vu theo phase

### Phase 0

- review scope giao dien admin

### Phase 1

- review `API.md` de dam bao dashboard can gi se co trong contract

### Phase 2

- khong tu viet protocol
- chuan bi UI service boundary cho network input

### Phase 3

- noi admin login UI vao auth result thuc

### Phase 4

- build login form
- build dashboard shell
- build machine list stub
- build control panel

### Phase 5

- bind dashboard vao state thuc
- hien ket qua command va machine state thuc
- hien ack neu co

### Phase 6

- finish notification area
- finish timer display
- finish chat/admin interaction area

### Phase 7

- fix cross-thread, lag, stale state, reconnect UI issues

### Phase 8

- chi sua release-blocking server UI bug
- rehearse dashboard demo path

### Phase 9

- demo admin dashboard

## 6. Ke hoach theo tuan

### Week 1

- create server login shell
- create dashboard shell
- create machine list stub

### Week 2

- bind UI vao service interfaces
- chuan bi status rendering

### Week 3

- bind dashboard vao login/status/lock/unlock flow thuc

### Week 4

- finish notification/timer/chat/admin controls

### Week 5

- fix server UI stability, thread-safety, reconnect display

### Week 6

- rehearse final admin-side demo

## 7. Handoff cho nguoi khac

Ban can noi ro:

- UI can nhan state nao
- UI can goi action nao
- state nao la loading, error, success
- control nao da noi that, control nao con stub

## 8. Nguyen tac tranh xung dot

- chi goi service/interface, khong parse packet trong form neu co the tach
- Member 2 own transport, ban own presentation
- auth flow phai theo result cua Member 5
- khong sua `Shared` de "cho nhanh"

## 9. Deliverables

- admin login form
- dashboard shell
- machine list/state view
- control panel
- realtime admin UI

## 10. Definition of Done

- admin dang nhap duoc
- machine state thay duoc tren dashboard
- admin thao tac command thay ket qua ro
- UI khong freeze va khong vo khi network event den
