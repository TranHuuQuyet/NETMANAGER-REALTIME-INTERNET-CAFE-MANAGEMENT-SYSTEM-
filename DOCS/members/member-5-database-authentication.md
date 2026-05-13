# Member 5 - Database & Authentication

## 1. Vai tro

Ban phu trach SQLite, login validation, luu account, luu session, va cac thong tin persistence co ban cho he thong.

## 2. Write Scope

Ban chi nen sua cac file/module lien quan den:

- `ServerApp/Database/`
- `ServerApp/Services/Auth/`
- `ServerApp/Services/Session/`
- `../API.md` va `../README.md` khi doi schema

Ban khong nen sua UI form, packet dispatcher cua Member 2, hay client UI.

## 3. Muc tieu cuoi cung

- Auth hoat dong on dinh.
- Du lieu user va session co the luu va lay lai duoc.
- Server co can cu de xac thuc admin/client.
- Schema don gian, de debug, de demo.

## 4. Luat de khong xung dot commit

- Schema la contract, nen moi thay doi phai thong qua Member 1 va Member 2.
- Neu auth can them enum/model chung, Member 5 chi de xuat; Member 2 se update `Shared/`.
- Khong de SQL loang ra UI.
- Khong de password handling bi su dung khac nhau giua cac module.
- Moi commit nen tach: schema, repository, auth service, session service, integration.

## 5. Cong viec can lam tu dau den cuoi

### Giai doan khoi tao

- chot schema toi thieu
- chot field can thiet cho `Users`, `Sessions`, `Machines`
- chot cach hash password neu co
- chot luong auth cho admin va client

### Giai doan data access

- tao repository/data access layer rieng
- khong viet SQL truc tiep trong UI
- tao ham add/get/update/validate
- tao error handling cho SQLite ro rang

### Giai doan authentication

- validate username/password
- tra ket qua success/fail ro rang
- phan biet admin, client, disabled, locked neu can
- ghi last login neu co

### Giai doan session and config

- luu session co ban
- luu machine mapping neu can
- luu config ket noi neu project can
- khong luu du lieu nhay cam khong can thiet

### Giai doan integration

- noi auth vao server login flow
- noi auth vao dashboard neu co admin login
- noi session vao state machine cua server
- dam bao ket qua auth khop voi packet contract

### Giai doan hardening

- kiem tra sai mat khau
- kiem tra user khong ton tai
- kiem tra database bi loi
- kiem tra concurrent access co an toan khong

### Giai doan release

- kiem tra login tu client
- kiem tra login tu admin
- kiem tra session tracking
- kiem tra database khong lam app crash khi loi

## 6. Ke hoach chi tiet theo phase

### Phase 1 - Schema

- [ ] Tao `Users`
- [ ] Tao `Sessions`
- [ ] Tao `Machines`
- [ ] Chot field va key

### Phase 2 - Data access

- [ ] Tao repository
- [ ] Tao query helpers
- [ ] Tao error handling
- [ ] Tao seed data neu can

### Phase 3 - Authentication

- [ ] Validate login
- [ ] Tra auth result
- [ ] Luu last login
- [ ] Phan loai role

### Phase 4 - Session storage

- [ ] Luu session start/end
- [ ] Luu machine mapping
- [ ] Luu config co ban
- [ ] Dong bo voi server state

### Phase 5 - Stability

- [ ] Test sai mat khau
- [ ] Test user khong ton tai
- [ ] Test DB error handling
- [ ] Test concurrent access

## 7. Cach lam de khong overlap

- Ban owned auth, session, va DB.
- Ban khong sua UI truct tiep.
- Ban khong doi packet format neu chua thong qua Member 2 va Member 1.
- Ban phai cung cap service interface ro de Member 3 va 4 dung.

## 8. Nguyen tac

- Schema don gian hon schema dep.
- Khong de plaintext password ton tai trong luong xu ly.
- Khong de auth result mo ho.
- Khong de SQL phu thuoc vao control UI.

## 9. Deliverables can nop

- SQLite schema hoac script.
- Data access layer.
- Auth service.
- Session/config storage.

## 10. Definition of Done

- Login on dinh.
- Data doc/ghi duoc.
- Team khac co the dung auth service ma khong doan schema.
- DB loi khong lam sap demo.
