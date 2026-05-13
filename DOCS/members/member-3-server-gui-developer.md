# Member 3 - Server GUI Developer

## 1. Vai tro

Ban phu trach giao dien admin dashboard cua server. UI phai ro rang, realtime, de thao tac, va khong tre khi network co nhieu event.

## 2. Write Scope

Ban chi nen sua cac file/module lien quan den:

- `ServerApp/Forms/`
- `ServerApp/Views/` neu co
- `ServerApp/Services/` cho phan UI bridge
- `ServerApp/Models/` neu can model hien thi
- `../README.md` chi khi cap nhat huong dan dashboard

Ban khong nen sua packet schema, SQL schema, hay client UI.

## 3. Muc tieu cuoi cung

- Admin co the dang nhap va vao dashboard.
- Danh sach may cap nhat realtime.
- Lock, unlock, notification, timer, chat thao tac duoc.
- UI khong freeze khi co socket event.

## 4. Luat de khong xung dot commit

- UI chi call vao network/service interface, khong tu y parse packet trong form.
- Nha mot file dashboard se khong duoc Member 4 sua cung luc.
- Neu can thay doi contract, phai trao doi voi Member 2 va Member 1 truoc.
- Moi commit UI nen tach rieng: layout, binding, state render, action buttons, polish.

## 5. Cong viec can lam tu dau den cuoi

### Giai doan khoi tao

- tao khung dashboard
- tao layout header, content, control panel
- chot naming convention cho control
- tao form login admin neu can

### Giai doan machine view

- hien thi danh sach may
- hien thi trang thai online, offline, locked, playing
- hien thi IP, machine name, timer, connection state neu co
- tao refresh pattern cho machine list

### Giai doan control flow

- tao nut lock, unlock, notification, timer
- tao area xem chat neu co
- tao hanh dong admin ro rang, khong lam loan UI
- mapping button event sang network service

### Giai doan realtime

- nhan update tu network service
- invoke ve UI thread dung cach
- cap nhat mau sac, icon, badge, label theo state
- kiem tra khong co deadlock hay cross-thread error

### Giai doan polish

- don dep spacing, typography, va visual hierarchy
- dam bao dashboard de demo
- giam noise UI, tang readability
- thiet lap empty state va error state ro rang

### Giai doan integration

- ket noi voi socket layer
- ket noi voi auth layer neu dashboard co login
- ket noi voi shared packet models
- test voi client lock/unlock/timer/notify

### Giai doan release

- kiem tra dashboard chay on dinh khi co nhieu event
- kiem tra refresh lien tuc khong lam lag
- kiem tra admin action gui ra dung packet
- kiem tra UI sau reconnect va after disconnect

## 6. Ke hoach chi tiet theo phase

### Phase 1 - Layout

- [ ] Tao dashboard shell
- [ ] Tao login form
- [ ] Tao machine list panel
- [ ] Tao control panel

### Phase 2 - State display

- [ ] Hien machine status
- [ ] Hien connection state
- [ ] Hien timer state
- [ ] Hien notification area

### Phase 3 - Actions

- [ ] Gui lock command
- [ ] Gui unlock command
- [ ] Gui notification
- [ ] Gui timer command

### Phase 4 - Realtime UI

- [ ] Listen network updates
- [ ] Update UI thread safely
- [ ] Refresh machine cards
- [ ] Handle offline state

### Phase 5 - Demo readiness

- [ ] Polish visuals
- [ ] Test multi-client updates
- [ ] Remove UI clutter
- [ ] Validate interaction speed

## 7. Cach lam de khong overlap

- Bo cuc va styling la cua ban.
- Network dispatcher va packet parser la cua Member 2.
- Auth result va session state la cua Member 5.
- Ban chi nhan state tu service, khong nam quyen doi protocol.

## 8. Hanh vi UI can dam bao

- Khong block khi dang nhan packet.
- Khong update truc tiep tu background thread.
- Khong de button action gay trung lap packet.
- Khong de dashboard mat trang thai khi socket reconnect.

## 9. Deliverables can nop

- Admin login form.
- Realtime dashboard.
- Machine list/state view.
- Control panel cho lock/unlock/notification/timer.
- UI integration voi network service.

## 10. Definition of Done

- Admin thao tac on dinh.
- Machine state nhin thay ngay.
- UI khong freeze.
- Dashboard demo duoc ma khong can giai thich nhieu.
