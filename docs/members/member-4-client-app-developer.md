# Member 4 - Client App Developer

## 1. Vai tro va muc tieu

Ban phu trach ung dung client. Client phai ket noi duoc voi server, hien thi thong bao va trang thai, va hien man hinh khoa khi server yeu cau.

## 2. Pham vi cong viec

- Tao form ket noi IP/Port.
- Tao flow dang nhap client.
- Nhan packet tu server va cap nhat UI.
- Tao lock screen full-screen.
- Hien thi timer va notification.
- Ho tro chat co ban.

## 3. Dau vao can nam

- IP/Port server.
- Client ID hoac ten may.
- Packet type: login, lock, unlock, timer, notification, chat, status.

## 4. Luong lam viec tu a den z

### Buoc 1: Tao form connect

- Nhap IP.
- Nhap Port.
- Bam connect.
- Hien trang thai ket noi thanh cong/that bai.

### Buoc 2: Tao form login client

- Gui username/password hoac client code len server.
- Nhan ket qua dang nhap.
- Neu thanh cong, hien man hinh client chinh.

### Buoc 3: Nhan lenh realtime

- Notification: hien popup hoac message.
- Lock: chuyen sang man hinh khoa.
- Unlock: tro lai man hinh binh thuong.
- Timer: cap nhat dong ho/remaining time.

### Buoc 4: Tao lock screen

- Full-screen.
- Khong cho thao tac thoat de dang.
- Co thong diep ro rang.
- Chi mo khoa khi server gui lenh unlock.

### Buoc 5: Chat co ban

- Hien hoi thoai voi admin.
- Gui message tu client.
- Nhan message tu server.

### Buoc 6: Xu ly mat ket noi

- Bao cho nguoi dung biet server mat ket noi.
- Thu reconnect neu duoc phep.
- Khong lam app crash.

## 5. Cach code de on dinh

- Tach networking service khoi form.
- UI chi lam viec voi state va event.
- Khi nhan packet phai parse an toan.
- Khi lock/unlock phai dung state machine ro rang.

## 6. Checklist A-Z cho Member 4

- A: Auto reconnect co ban.
- B: Build connect form.
- C: Client login flow.
- D: Display notification.
- E: Event handler for server command.
- F: Full-screen lock screen.
- G: Graceful disconnect handling.
- H: Handle timer update.
- I: Invoke UI safely.
- J: Join chat session.
- K: Keep client responsive.
- L: Lock / unlock state switch.
- M: Message receive/send.
- N: Network status indicator.
- O: Offline notice.
- P: Packet parser.
- Q: Queue incoming events neu can.
- R: Realtime updates.
- S: Session info display.
- T: Timer remaining display.
- U: Unlock flow.
- V: Validate connection state.
- W: Warn user when server goes down.
- X: eXit lock only by server command.
- Y: Yield control after network receive.
- Z: Zero crash on common socket errors.

## 7. Test can chay

- Ket noi server thanh cong.
- Dang nhap client thanh cong.
- Nhan notification.
- Nhan lock va unlock.
- Timer cap nhat dung.
- Chat gui/nhan on dinh.
- Mat ket noi khong lam app dong bat thuong.

## 8. Deliverables can nop

- Client connect form.
- Client login form.
- Main client UI.
- Lock screen full-screen.
- Notification/timer/chat handling.

## 9. Definition of Done

- Client ket noi va nhan lenh tot.
- Man hinh khoa hoat dong dung.
- UI khong dong bang khi co event mang.
- Demo client co the chay doc lap va cung server.
