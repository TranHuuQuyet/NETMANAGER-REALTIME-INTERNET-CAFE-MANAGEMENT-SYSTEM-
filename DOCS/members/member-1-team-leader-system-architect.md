# Member 1 - Team Leader / System Architect

## 1. Vai tro

Ban la nguoi giu huong di tong the cua project. Ban khong can lam het code, nhung ban phai dam bao:

- scope khong bi loang
- packet contract khong bi doi lung tung
- tung member co write scope rieng
- integration khong bi vo
- team co the tiep tuc lam viec ma khong mat boi canh

## 2. Write Scope

Ban chi nen sua cac file sau:

- `../LEADER_FLOW.md`
- `../TASKS.md`
- `../BUGS.md`
- `../README.md` khi chot thong tin tong quan

Ban khong nen sua truc tiep code runtime trong `ServerApp`, `ClientApp`, `Shared` tru khi dang review integration.

## 3. Muc tieu cuoi cung

- Project co mot MVP ro rang va demo duoc.
- Moi member biet minh lam gi, lam den dau, va tiep theo la gi.
- Server, client, auth, DB va docs dung mot contract.
- Khong co overlap write scope giua cac member.

## 4. Luat dieu phoi de tranh xung dot commit

- Moi task phai co owner chinh mot nguoi.
- Khong cho hai nguoi sua cung mot file cung luc neu khong bat buoc.
- Neu bat buoc sua file chung, chi sua phan riang: vi du `API.md`, `Shared` packet, hoac `README.md`.
- Moi commit phai nho va co y nghia ro.
- Khong tron UI + networking + DB trong cung mot commit neu co the tach.
- Moi thay doi packet hoac state phai cap nhat docs ngay.
- Neu Member 2 chot contract, Member 3 va 4 phai theo contract do, khong tu y doi field.

## 5. Cong viec can lam tu dau den cuoi

### Giai doan khoi tao

- chot ten project va MVP
- chot pham vi co the demo
- loai bo tinh nang ngoai scope
- chot branch convention va commit convention
- chot folder structure
- chot luot lam viec cua tung member

### Giai doan thiet ke

- chot structure `ServerApp`, `ClientApp`, `Shared`
- chot packet type va state model
- chot async model cho socket
- chot schema SQLite muc tieu
- chot output mong doi cua tung module

### Giai doan xay nen tang

- theo doi TCP core
- theo doi auth core
- theo doi GUI core
- theo doi DB core
- kiem tra moi module co dung contract khong

### Giai doan tich hop

- review source truoc khi merge
- kiem tra server va client co cung hieu packet khong
- kiem tra UI khong bi block boi network
- kiem tra DB auth khong lam crash app
- kiem tra multi-client flow

### Giai doan hoan thien

- uu tien bug lien quan login, reconnect, lock, timer, notification
- doi chieu bug list voi test result
- dam bao docs va code khop nhau
- chot demo checklist

## 6. Ke hoach chi tiet theo phase

### Phase 0 - Project control

- [ ] Chot scope MVP bang 1 doan ngan
- [ ] Chot danh sach tinh nang se lam va khong lam
- [ ] Chot ten project chinh thuc
- [ ] Chot folder ownership cho tung member
- [ ] Chot rule ve branch va commit
- [ ] Chot file nao la source of truth cho docs

### Phase 1 - Architecture and contract

- [ ] Xac nhan luong server/client
- [ ] Xac nhan danh sach packet core
- [ ] Xac nhan enum trang thai may
- [ ] Xac nhan enum lenh dieu khien
- [ ] Xac nhan rule parse JSON
- [ ] Xac nhan rule xu ly packet loi

### Phase 2 - Build tracking

- [ ] Tao task board dau tien
- [ ] Kiem tra cong viec cua tung member hang ngay
- [ ] Ghi blocker ngay khi phat sinh
- [ ] Ghi decision ngay khi co thay doi lon
- [ ] Dieu chinh uu tien neu module nao bi tre

### Phase 3 - Integration and release

- [ ] Review merge request
- [ ] Kiem tra regression
- [ ] Kiem tra demo flow
- [ ] Kiem tra bug list
- [ ] Kiem tra docs cuoi cung

## 7. Hanh dong hang ngay

- Kiem tra `TASKS.md` truoc khi bat dau.
- Kiem tra `TASKS.md` de lay viec tiep theo.
- Xac nhan ai dang lam gi de tranh overlap.
- Neu co change ve packet, update `API.md` ngay.
- Neu co bug, dua vao `BUGS.md` ngay.
- Neu co thay doi ve structure, ghi vao `README.md` hoac `TASKS.md`.

## 8. Deliverables can nop

- Roadmap chia phase ro rang.
- Architecture va API contract dong bo.
- Task tracking cap nhat lien tuc.
- Bug list va decision log day du.
- Demo flow on dinh.

## 9. Definition of Done

- Scope khong lech.
- Cac module khong dap nhau ve write scope.
- Moi member co task ro rang va co the lam lap tuc.
- Server, client va DB khong xung dot contract.
- Team co the demo duoc ma khong can giai thich lai tu dau.
