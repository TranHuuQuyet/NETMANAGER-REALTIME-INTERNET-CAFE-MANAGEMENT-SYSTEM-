# Member 4 - Client App Developer

## 1. Vai tro

Ban phu trach ung dung client.
Muc tieu cua ban la tao client co the connect, login, nhan lenh realtime, hien lock screen khi can, va giu trai nghiem on dinh cho may client.

## 2. Write Scope

Ban duoc uu tien sua:

- `ClientApp/`
- client-side forms
- client-side views
- client-side UI bridge/services neu can cho UI

Ban khong nen sua:

- packet schema
- server dashboard
- database/auth internals

## 3. Thu ban so huu

- connect form
- client login screen
- main client screen
- lock screen
- notification/timer/chat display
- client-side command reaction
- client-side reconnect UX

## 4. Dependency cua ban

- network/service interface tu Member 2
- login result flow tu Member 2 va Member 5
- scope va phase order tu Member 1

## 5. Nhiem vu theo phase

### Phase 0

- review client scope

### Phase 1

- review contract de biet client nhan/gui gi

### Phase 2

- chuan bi service boundary cho client UI

### Phase 3

- noi client login UI vao auth result thuc

### Phase 4

- build connect form
- build login shell
- build main client shell
- build lock screen shell

### Phase 5

- bind client UI vao login/status/lock/unlock flow thuc
- hien ket noi va trang thai ro rang

### Phase 6

- finish notification/timer/chat display
- finish unlock reaction
- finish status presentation can thiet

### Phase 7

- fix disconnect/reconnect UX
- fix invalid packet crash risk
- fix lock state hoac stale UI

### Phase 8

- chi sua release-blocking client UI bug
- rehearse client demo path

### Phase 9

- demo client behavior

## 6. Ke hoach theo tuan

### Week 1

- create connect screen
- create login shell
- create main shell
- create lock screen shell

### Week 2

- bind UI vao service interfaces
- chuan bi receive-state rendering

### Week 3

- bind client vao core flow: login, status, lock/unlock

### Week 4

- finish notification, timer, chat, lock flow

### Week 5

- fix reconnect, disconnect, invalid state, UI stability

### Week 6

- rehearse final client-side demo

## 7. Handoff cho nguoi khac

Ban can noi ro:

- client can nhan event nao
- client can render state nao
- lock screen can input gi
- phan nao da noi that, phan nao con placeholder

## 8. Nguyen tac tranh xung dot

- UI chi render state va goi action, khong tu invent packet
- Member 2 own networking core
- Member 5 own auth logic
- ban khong sua server-side code de fix client issue neu chua duoc giao

## 9. Deliverables

- connect form
- login flow
- main client UI
- full-screen lock screen
- notification/timer/chat handling

## 10. Definition of Done

- client connect va login duoc
- client nhan lenh realtime dung
- lock screen chay dung
- reconnect/disconnect khong lam vo trai nghiem co ban
