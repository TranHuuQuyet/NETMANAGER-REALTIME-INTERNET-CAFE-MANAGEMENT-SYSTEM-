# Member 4 - Client App Developer

## 1. Vai tro

Ban phu trach ung dung client. Client phai ket noi duoc voi server, nhan lenh realtime, hien lock screen khi can, va giu UI on dinh.

## 2. Write Scope

Ban chi nen sua cac file/module lien quan den:

- `ClientApp/Forms/`
- `ClientApp/Services/`
- `ClientApp/Models/`
- `ClientApp/Views/` neu co
- `ai-docs/` chi khi cap nhat huong dan client

Ban khong nen sua server dashboard, packet contract, hay database layer.

## 3. Muc tieu cuoi cung

- Client connect va login duoc.
- Client nhan notification, timer, lock, unlock, chat.
- Client co lock screen full-screen.
- Client co xu ly disconnect va reconnect co ban.

## 4. Luat de khong xung dot commit

- Client UI chi nhan event va render state, khong parse packet trong form neu co the tach.
- Khong sua networking core tru khi co agreed interface.
- Khong doi packet field neu Member 2 chua chot contract.
- Moi commit nen tach: connect/login, receive flow, lock screen, chat/timer, polish.

## 5. Cong viec can lam tu dau den cuoi

### Giai doan khoi tao

- tao connect form
- tao login flow client
- tao client state model
- chot cach luu IP/Port neu can

### Giai doan connection flow

- kiem tra ket noi den server
- gui login packet
- hien trang thai ket noi va auth ro rang
- xu ly loi connect khong lam crash app

### Giai doan realtime receive

- nhan notification tu server
- nhan timer update
- nhan lock/unlock command
- nhan chat message
- nhan status hoac session update neu co

### Giai doan lock screen

- tao man hinh khoa full-screen
- chan thao tac khong dung
- hien thong diep ro rang
- chi mo khoa khi nhan `UNLOCK`

### Giai doan chat va status

- hien chat voi admin
- gui message tu client
- cap nhat status khi co thay doi
- dam bao flow chat khong lam tre UI

### Giai doan resilience

- bao cho nguoi dung khi server mat ket noi
- thu reconnect co ban
- giu local state khong bi vo khi disconnect
- khong de packet xau lam crash client

### Giai doan polish

- don dep form, labels, va state feedback
- uu tien readability hon hieu ung phuc tap
- giup nguoi dung biet dang o trang thai nao

## 6. Ke hoach chi tiet theo phase

### Phase 1 - Connect and login

- [ ] Tao connect form
- [ ] Tao login form
- [ ] Tao connect state
- [ ] Tao auth result display

### Phase 2 - Receive commands

- [ ] Nhan notification
- [ ] Nhan lock/unlock
- [ ] Nhan timer
- [ ] Nhan chat

### Phase 3 - Lock screen

- [ ] Tao fullscreen lock form
- [ ] Chan thao tac khong dung
- [ ] Hien unlock state

### Phase 4 - Stability

- [ ] Xu ly disconnect
- [ ] Xu ly reconnect
- [ ] Xu ly invalid packet
- [ ] Xu ly network error an toan

### Phase 5 - Demo readiness

- [ ] Test ket noi on dinh
- [ ] Test lock/unlock
- [ ] Test notification/timer/chat
- [ ] Test UI khong freeze

## 7. Cach lam de khong overlap

- Ban chi owned `ClientApp`.
- Server dashboard la cua Member 3.
- Network dispatcher la cua Member 2.
- Auth flow la cua Member 5.
- Neu can doi contract, ban phai thong qua Member 2 va Member 1 truoc.

## 8. Nguyen tac code

- Tach networking service khoi form.
- UI chi lam viec voi state va event.
- Khong de lock flow bi phu thuoc vao button state alone.
- Khong update UI truc tiep tu thread socket.

## 9. Deliverables can nop

- Connect form.
- Client login flow.
- Main client UI.
- Full-screen lock screen.
- Notification, timer, chat handling.

## 10. Definition of Done

- Client ket noi va nhan lenh on dinh.
- Lock screen chay dung.
- UI khong block.
- Client demo doc lap duoc va hop voi server.

