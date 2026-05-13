# Member 6 - Tester & Documentation

## 1. Vai tro

Ban phu trach test, bug report, tai lieu, va ho tro demo. Ban giup team biet phan nao dang on, phan nao dang hong, va lam sao chay project dung cach.

## 2. Write Scope

Ban chi nen sua cac file/module lien quan den:

- `../README.md`
- `../TASKS.md`
- `../BUGS.md`
- cac tai lieu trong `DOCS/` neu can

Ban khong nen sua runtime code tru khi dang verify bug va co owner ro rang.

## 3. Muc tieu cuoi cung

- Demo flow chay duoc tren may that.
- Bugs duoc ghi ro, uu tien ro, va de lap lai.
- Documentation de hieu va co the dung ngay.
- Nguoi moi tham gia co the doc docs de tiep tuc work.

## 4. Luat de khong xung dot commit

- Ban khong sua logic chuc nang neu chi can test hoac doc.
- Ban khong doi packet schema neu khong co phan cong tu Member 1.
- Ban phai ghi bug theo format chung de team khong loan.
- Moi commit doc nen tach: test plan, bug log, demo guide, README update.

## 5. Cong viec can lam tu dau den cuoi

### Giai doan khoi tao

- lap test plan cho core flow
- lap checklist demo
- xac dinh test matrix cho multi-client
- dinh nghia format bug report

### Giai doan smoke test

- test connect
- test login
- test chat, notification, timer, lock, unlock
- test multi-client co ban

### Giai doan regression

- test disconnect
- test server restart
- test packet invalid
- test reconnect
- test UI freeze va thread issue

### Giai doan bug tracking

- ghi reproduction steps
- ghi expected vs actual
- danh severity
- theo doi workaround tam thoi neu co

### Giai doan documentation

- cap nhat README, guide, va demo notes
- cap nhat checklist chay server/client
- cap nhat faq loi thuong gap
- dam bao docs khong mau thuan voi code

### Giai doan release support

- chay final smoke test
- xac nhan build co the demo
- chuan bi script trinh bay ngan
- san sang ho tro khi co loi ngay demo

## 6. Ke hoach chi tiet theo phase

### Phase 1 - Planning

- [ ] Tao test plan
- [ ] Tao demo checklist
- [ ] Tao bug template
- [ ] Tao regression list

### Phase 2 - Functional test

- [ ] Test connect
- [ ] Test login
- [ ] Test notification
- [ ] Test chat
- [ ] Test timer
- [ ] Test lock/unlock

### Phase 3 - Risk test

- [ ] Test multi-client
- [ ] Test disconnect
- [ ] Test timeout
- [ ] Test invalid packet
- [ ] Test server restart

### Phase 4 - Docs

- [ ] Cap nhat README
- [ ] Cap nhat run guide
- [ ] Cap nhat demo flow
- [ ] Cap nhat FAQ

### Phase 5 - Release support

- [ ] Final smoke test
- [ ] Final bug sweep
- [ ] Demo rehearsal
- [ ] Final checklist

## 7. Cach lam de khong overlap

- Ban owned doc, test, va bug tracking.
- Ban khong sua core logic neu khong can.
- Neu phat hien bug do code, ban ghi lai, roi giao dung owner sua.
- Ban giup keep source of truth cho team, khong thay the owner chinh.

## 8. Bug report format

Moi bug nen co:

- title
- module
- steps to reproduce
- expected result
- actual result
- severity
- workaround neu co

## 9. Deliverables can nop

- Test report.
- Bug list.
- README va huong dan chay.
- Demo checklist.
- Script demo ngan.

## 10. Definition of Done

- Team co the chay project ma khong hoi lai qua nhieu.
- Bug lon duoc ghi nhan va de uu tien ro.
- Demo co checklist san.
- Tai lieu khong bi loi thoi.
