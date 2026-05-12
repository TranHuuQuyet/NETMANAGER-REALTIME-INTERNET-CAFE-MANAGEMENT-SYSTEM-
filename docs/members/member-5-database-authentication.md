# Member 5 - Database & Authentication

## 1. Vai tro va muc tieu

Ban phu trach SQLite, login validation, account storage, va session/config luu tru co ban. Muc tieu la giu auth don gian, on dinh, de demo.

## 2. Pham vi cong viec

- Tao database SQLite.
- Tao bang tai khoan admin/client.
- Viet logic login/validation.
- Luu session co ban va cau hinh can thiet.
- Ho tro lookup thong tin may neu can.

## 3. Dau vao can nam

- Danh sach user admin/client.
- Quyen truy cap cua moi loai tai khoan.
- Cac truong can luu: username, password hash, role, machineId, status, lastLogin.

## 4. Luong lam viec tu a den z

### Buoc 1: Thiet ke schema

- Bang `Users`.
- Bang `Sessions` neu can.
- Bang `Machines` neu can luu cau hinh may.
- Khong thiet ke qua phuc tap.

### Buoc 2: Tao repository/data access layer

- Viet class truy van DB rieng.
- Khong viet SQL truc tiep trong UI.
- Co ham add, get, validate, update.

### Buoc 3: Authentication

- Xac thuc admin.
- Xac thuc client.
- Tra ve ket qua ro rang: success, invalid, locked, disabled.

### Buoc 4: Session va config

- Luu session id/co ban neu can.
- Luu thong tin ket noi hoac cau hinh client.
- Khong luu thong tin nhay cam khong can thiet.

### Buoc 5: Tich hop voi server

- Server goi ham auth truoc khi chap nhan client neu can.
- Server dong bo user state voi machine state.

### Buoc 6: Test data

- Tao it nhat 1 admin.
- Tao vai client test.
- Kiem tra case dung mat khau, sai mat khau, user khong ton tai.

## 5. Cach lam de de demo

- Duong di auth nen ngan.
- Khong can UI quan ly phuc tap.
- Chi can login thanh cong va luu duoc trang thai co ban.
- Neu khong kip, co the fake mot phan data trong giai doan dau nhung cuoi cung phai co DB that.

## 6. Checklist A-Z cho Member 5

- A: Account table.
- B: Basic login validation.
- C: Connection config storage.
- D: Data access layer.
- E: Error handling cho SQLite.
- F: Fetch user by username.
- G: Get role/permission.
- H: Hash password neu co the.
- I: Integrate voi server auth.
- J: JSON config neu can, nhung uu tien DB.
- K: Keep schema simple.
- L: Login success/fail response.
- M: Machine mapping neu can.
- N: Normalize data fields.
- O: Optional session table.
- P: Password check.
- Q: Query simple and safe.
- R: Record last login.
- S: Session storage.
- T: Test invalid login.
- U: Update user state.
- V: Validate required fields.
- W: Write minimal SQL.
- X: eXpose simple API cho team dung.
- Y: Yield clear auth result codes.
- Z: Zero leakage of plaintext password.

## 7. Test can chay

- Login admin dung.
- Login client dung.
- Login sai mat khau.
- User khong ton tai.
- Server goi auth va nhan ket qua dung.
- Luu session/config co ban.

## 8. Deliverables can nop

- SQLite database file hoac schema script.
- Data access layer.
- Auth service.
- Session/config storage co ban.

## 9. Definition of Done

- Login hoat dong on dinh.
- DB duoc truy van tu code that.
- Team khac co the dung auth service de xac thuc.
- Khong co loi DB nghiem trong khi demo.
