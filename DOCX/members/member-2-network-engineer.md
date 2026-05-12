# Member 2 - Network Engineer

## 1. Vai tro

Ban phu trach toan bo lop networking. Muc tieu cua ban la giu cho TCP on dinh, packet ro rang, multi-client chay duoc, va khong lam tre UI.

## 2. Write Scope

Ban chi nen sua cac file/module lien quan den:

- `Shared/`
- `ServerApp/Networking/`
- `ClientApp/Networking/`
- `ai-docs/API.md`
- `ai-docs/DECISIONS.md` khi co thay doi protocol

Ban khong nen sua UI form, database layer, hay auth repository tru khi dang tich hop va co owner ro rang.

## 3. Muc tieu cuoi cung

- Server va client ket noi duoc qua TCP.
- Packet JSON gui nhan on dinh.
- Multi-client hoat dong song song.
- Disconnect va timeout khong lam sap app.
- Cac module khac co the dung network API ma khong phai doan.

## 4. Luat de khong xung dot commit

- Toan bo packet schema phai do ban quan ly.
- Neu schema doi, ban phai update `API.md` truoc hoac cung luc voi code.
- Ban khong sua UI state cua Member 3/4 truc tiep.
- Ban khong sua SQL query cua Member 5.
- Ban chi expose interface/contract ro rang de module khac ket noi.
- Moi commit network nen tach rieng: connection, packet contract, dispatcher, resilience.

## 5. Cong viec can lam tu dau den cuoi

### Giai doan khoi tao

- xac dinh IP, port, va mo hinh ket noi
- chot cach frame packet on dinh
- chot cach encode/decode JSON
- tao skeleton server listener va client connector

### Giai doan core connection

- viet TCP server accept loop
- viet TCP client connect loop
- test echo/handshake co ban
- dam bao server khong block khi mot client cham
- tao connection/session object rieng cho moi client

### Giai doan packet contract

- dinh nghia packet type chinh
- xay serializer va parser
- chot loi output neu packet sai format
- dam bao packet model khop voi `API.md`
- khong thay doi schema vo toi va lap lai

### Giai doan dispatch

- route packet theo `type`
- tach handler cho login, status, chat, lock, unlock, timer, notification
- tra ket qua ro rang khi packet khong hop le
- ghi log loi socket va loi parse

### Giai doan on dinh

- bat exception socket co kiem soat
- xu ly disconnect sach se
- ho tro reconnect co ban
- kiem tra timeout va mat ket noi giua chung
- giu thread UI khong bi block

### Giai doan integration

- ket noi voi server GUI
- ket noi voi client GUI
- kiem tra broadcast neu can
- kiem tra state sync giua nhieu client
- kiem tra thoi gian phan hoi khi co nhieu event lien tiep

### Giai doan release

- chay test multi-client
- chay test packet invalid
- chay test server restart
- chay test reconnect sau disconnect
- xac nhan network layer doan truoc demo

## 6. Ke hoach chi tiet theo phase

### Phase 1 - Connection

- [ ] Tao server listener
- [ ] Tao client connector
- [ ] Tao handshake
- [ ] Tao basic send/receive loop

### Phase 2 - Packet contract

- [ ] Dinh nghia packet type
- [ ] Dinh nghia shared DTO
- [ ] Dinh nghia framing rule
- [ ] Dinh nghia parse error behavior

### Phase 3 - Routing and state

- [ ] Xay packet dispatcher
- [ ] Ganh client session state
- [ ] Ganh server machine state
- [ ] Dong bo status update

### Phase 4 - Resilience

- [ ] Xu ly disconnect
- [ ] Xu ly timeout
- [ ] Xu ly reconnect
- [ ] Ghi log loi mang

### Phase 5 - Integration

- [ ] Ket noi voi server UI
- [ ] Ket noi voi client UI
- [ ] Test broadcast
- [ ] Test multi-client

## 7. Chia task de lam song song khong dap nhau

- Subtask A: connection loop va session object
- Subtask B: packet model, serializer, parser
- Subtask C: dispatcher va handlers
- Subtask D: resilience va reconnect

Moi subtask phai co file ownership ro. Khong doi dong code cua subtask khac neu chua review.

## 8. Nguyen tac ky thuat

- Khong doc/ghi socket tren UI thread.
- Khong update WinForms control truc tiep tu background thread.
- Khong de schema packet thay doi ma khong cap nhat docs.
- Khong de loi socket lam sap toan bo server.
- Khong de message format tua nhau giua server va client.

## 9. Deliverables can nop

- TCP server/client core.
- Packet parser/serializer.
- Dispatcher and handlers.
- Reconnect and disconnect handling.
- Multi-client test note.

## 10. Definition of Done

- 2 den 3 client ket noi on dinh.
- Packet qua lai dung schema.
- Disconnect khong lam crash app.
- Module khac co the tich hop vao API ma khong xung dot.

