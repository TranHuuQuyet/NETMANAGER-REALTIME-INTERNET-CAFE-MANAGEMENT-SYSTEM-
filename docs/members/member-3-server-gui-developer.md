# Member 3 - Server GUI Developer

## 1. Vai tro va muc tieu

Ban phu trach giao dien admin dashboard. UI phai de nhin, de demo, cap nhat realtime va khong bi tre khi co nhieu su kien tu mang.

## 2. Pham vi cong viec

- Tao man hinh login admin.
- Tao dashboard chinh.
- Hien thi danh sach may va trang thai.
- Tao control panel de lock/unlock, notification, timer.
- Hien thi chat neu can.

## 3. Nhu cau UI can dat

- Ro rang, de su dung, de trinh dien.
- Trang thai may thay doi phai nhin thay ngay.
- Button phai co hanh dong cu the.
- Khong block UI khi dang nghe socket.

## 4. Luong lam viec tu a den z

### Buoc 1: Tao layout co ban

- Chia man hinh thanh header, sidebar/control, main machine list.
- Dat cac thanh phan chinh truoc, style sau.

### Buoc 2: Login admin

- Tao form dang nhap.
- Kiem tra thong tin co ban.
- Neu login thanh cong thi vao dashboard.

### Buoc 3: Hien thi machine list

- Moi may co card hoac row rieng.
- Hien thi ten may, IP, trang thai, timer, ket noi.
- Co mau sac phan biet online/offline/locked/playing.

### Buoc 4: Control panel

- Nut lock.
- Nut unlock.
- Nut notification.
- Nut start/stop timer neu can.

### Buoc 5: Realtime refresh

- Cap nhat UI bang event/Invoke an toan thread.
- Khong cap nhat truc tiep tu network thread.

### Buoc 6: Demo mode

- UI phai san sang trinh dien, de view.
- Khong nhieu text, khong qua rat.

## 5. Cach to chuc code

- Tach form, control, service rieng.
- Khong viet logic network qua nhieu trong form.
- Dung service hoac controller de nhan su kien tu server.
- Dat ten control de hieu: `btnLock`, `btnUnlock`, `lstMachines`.

## 6. Checklist A-Z cho Member 3

- A: Align layout dep va ro.
- B: Build login form.
- C: Card/row machine list.
- D: Display state by color.
- E: Event-driven refresh.
- F: Full dashboard view.
- G: Group controls hop ly.
- H: Handle network updates an toan.
- I: Invoke UI thread dung cach.
- J: Just enough information, khong qua tai.
- K: Keep UI responsive.
- L: Lock/unlock buttons ro rang.
- M: Machine status realtime.
- N: Notification panel.
- O: Overlay hoac highlight khi can.
- P: Progress/timer display.
- Q: Quick actions cho admin.
- R: Realtime state change.
- S: Search/filter neu co thoi gian.
- T: Timer display.
- U: Update list on event.
- V: Visual clarity.
- W: Window states on login/logout.
- X: eXecute no blocking work on UI thread.
- Y: Yield to background network service.
- Z: Zero freeze on normal use.

## 7. Test can chay

- Login admin vao dashboard.
- Thay doi machine state va xem UI cap nhat.
- Bam lock/unlock va xem nut/label doi ngay.
- Notification hien len ro rang.
- UI van chay duoc khi co nhieu event.

## 8. Deliverables can nop

- Login admin form.
- Dashboard chinh.
- Machine list realtime.
- Control panel lock/unlock/notification.
- UI khong block khi receive event.

## 9. Definition of Done

- Admin co the quan sat va dieu khien may.
- Dashboard demo nhin ro, khong loi visual lon.
- Realtime update oon dinh.
- Khong crash khi nhan nhieu su kien.
