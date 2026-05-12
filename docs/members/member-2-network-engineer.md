# Member 2 - Network Engineer

## 1. Vai tro va muc tieu

Ban phu trach lop networking cua toan bo he thong, bao gom TCP server, TCP client, packet protocol, dispatch message, reconnect va xu ly loi socket.

## 2. Pham vi cong viec

- Xay dung TCP socket server va TCP socket client.
- Ho tro multi-client ket noi dong thoi.
- Tao co che gui/nhan JSON packet.
- Viet parser, dispatcher, handler cho cac loai packet.
- Xu ly disconnect, timeout, reconnect co ban.

## 3. Dau vao can nam

- Dia chi IP/Port server.
- Danh sach packet type.
- Quy uoc gui du lieu theo dong hoac delimiter.
- Trang thai client: online, offline, locked, playing.

## 4. Luong lam viec tu a den z

### Buoc 1: Tao ket noi co ban

- Viet server lang nghe tren mot port.
- Viet client ket noi den server.
- Kiem tra echo packet co ve duoc khong.

### Buoc 2: Ho tro nhieu client

- Moi client co mot session/connection object rieng.
- Server khong duoc block khi mot client cham.
- Dung async/await hoac worker thread hop ly.

### Buoc 3: Dinh dang packet

- Moi packet co field `type`.
- Cac field khac phai ro rang va on dinh.
- Khong doi schema lien tuc trong luc demo.

### Buoc 4: Viet dispatcher

- Parse JSON sang object/packet model.
- Dua packet ve dung handler theo `type`.
- Neu packet loi, tra response that bai ro rang.

### Buoc 5: Xu ly loi mang

- Bat exception socket.
- Dong ket noi sach se khi client thoat.
- Cho phep reconnect sau khi mat mang.

### Buoc 6: Test dong thoi

- Test 2 client, 3 client, sau do tang len neu can.
- Test cac case: login, chat, lock, unlock, timer, notification.
- Test mat ket noi giua chung.

## 5. Cach code de khong gay tre GUI

- Khong doc/ghi socket truc tiep tren UI thread.
- Tat ca thao tac network nang nen chay background.
- Chi marshal ket qua ve UI khi can cap nhat man hinh.
- Su dung queue hoac event de day du lieu len GUI.

## 6. Checklist A-Z cho Member 2

- A: Accept connection.
- B: Broadcast neu can gui nhieu client.
- C: Convert JSON sang object.
- D: Dispatch packet dung handler.
- E: Error handling.
- F: Framing packet ro rang.
- G: Guard against null/invalid data.
- H: Handle disconnect.
- I: Integrate voi ServerApp va ClientApp.
- J: Just one source of truth cho packet schema.
- K: Keep network thread separate from UI thread.
- L: Log loi socket.
- M: Manage multi-client session.
- N: Normalize message format.
- O: Observe timeout.
- P: Parse packet an toan.
- Q: Queue event neu can.
- R: Reconnect support.
- S: Session lifecycle.
- T: Thread-safe access.
- U: Update client state.
- V: Validate packet type.
- W: Work with server and client consistently.
- X: eXpose clear network API cho team khac goi.
- Y: Yield back to UI after background work.
- Z: Zero crash on normal network errors.

## 7. Test can chay

- Client login thanh cong.
- Client chat voi admin.
- Server gui lock/unlock.
- Server gui notification.
- Timer cap nhat dung.
- Mot client thoat khong lam sap toan bo server.

## 8. Deliverables can nop

- TCP server/client chay duoc.
- Packet model va parser.
- Dispatcher/handler cho packet chinh.
- Reconnect co ban.
- Test note voi ket qua multi-client.

## 9. Definition of Done

- Server nhan duoc nhieu client dong thoi.
- Packet doc/ghi on dinh.
- Reconnect/timeout khong lam app crash.
- Cac module khac dung duoc API network ma ban cung cap.
