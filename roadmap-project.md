NETMANAGER — REALTIME INTERNET CAFE MANAGEMENT SYSTEM 

Môn học 

Lập trình mạng 

Loại project 

Desktop Application — Client/Server Architecture 

Thời gian thực hiện 

2 tháng (8 tuần) 

Số lượng thành viên 

6 người 

 

1. GIỚI THIỆU ĐỀ TÀI 

1.1 Mô tả đề tài 

NetManager là hệ thống quản lí quán net hoạt động theo mô hình Client-Server sử dụng TCP Socket. 

Hệ thống cho phép: 

quản trị viên theo dõi trạng thái máy tính realtime  

gửi thông báo tới client  

lock/unlock máy  

quản lí session timer  

chat realtime giữa admin và client  

Project tập trung vào: 

networking  

realtime communication  

multithreading  

desktop application  

client-server architecture  

 

1.2 Mục tiêu project 

Mục tiêu chính 

Xây dựng hệ thống quản lí quán net realtime hoạt động ổn định trong mạng LAN. 

Mục tiêu kỹ thuật 

TCP Socket Communication  

Multi-client handling  

JSON packet communication  

Realtime synchronization  

GUI desktop application  

Session management  

Authentication system  

 

2. KIẾN TRÚC HỆ THỐNG 

               SERVER ADMIN 
        +------------------------+ 
        |  Admin Dashboard       | 
        |  Machine Manager       | 
        |  Realtime Control      | 
        +-----------+------------+ 
                    | 
             TCP SOCKET SERVER 
                    | 
     -------------------------------- 
      |            |              | 
   CLIENT 1     CLIENT 2      CLIENT 3 

 

3. TECH STACK 

Programming Language 

C#  

 

GUI Framework 

Windows Forms 

 

Networking 

TCP Socket  

async/await  

Multithreading  

 

Database 

SQLite 

 

IDE 

Microsoft Visual Studio 

 

Version Control 

GitHub 

 

4. CHỨC NĂNG HỆ THỐNG 

4.1 SERVER ADMIN 

Authentication 

Login/logout admin  

 

Machine Management 

Hiển thị danh sách máy realtime  

Trạng thái:  

Online  

Offline  

Locked  

Playing  

 

Realtime Notification 

Gửi thông báo tới client  

 

Lock/Unlock System 

Khóa/mở khóa máy client  

 

Session Timer 

Quản lí thời gian sử dụng  

 

Chat System 

Chat realtime với client  

 

4.2 CLIENT APP 

Server Connection 

Kết nối IP/Port  

 

Authentication 

Login/logout client  

 

Realtime Data 

Nhận thông báo  

Nhận timer  

Nhận trạng thái lock/unlock  

 

Chat System 

Chat với admin  

 

5. CẤU TRÚC PROJECT 

NetManager/ 
│ 
├── ServerApp/ 
│   ├── Forms/ 
│   ├── Networking/ 
│   ├── Models/ 
│   ├── Services/ 
│   └── Database/ 
│ 
├── ClientApp/ 
│   ├── Forms/ 
│   ├── Networking/ 
│   ├── Models/ 
│   └── Services/ 
│ 
├── Shared/ 
│   ├── Packets/ 
│   ├── Constants/ 
│   └── Utilities/ 
│ 
├── Docs/ 
│ 
└── README.md 

 

6. THIẾT KẾ PACKET 

Ví dụ packet JSON :

Login Packet 

{ 
  "type": "LOGIN", 
  "username": "client01", 
  "password": "123456" 
} 

 

Chat Packet 

{ 
  "type": "CHAT", 
  "sender": "PC01", 
  "message": "Máy em bị lag" 
} 

 

Lock Packet 

{ 
  "type": "LOCK" 
} 

 

Notification Packet 

{ 
  "type": "NOTIFICATION", 
  "message": "Server restart after 10 minutes" 
} 

 

7. KẾ HOẠCH PHÁT TRIỂN (8 TUẦN) 

Mục tiêu chung: Hoàn thành một hệ thống desktop demo ổn định cho môn Mạng máy tính, tập trung vào các chức năng cốt lõi và tránh tính năng mở rộng không cần thiết. 

Tuần 1 — Nền tảng mạng và cơ sở dự án 

Mục tiêu 

- Thiết lập repo, cấu trúc dự án và quy ước commit. 
- Xây dựng TCP server/client đơn giản trên LAN. 
- Đảm bảo nhiều client có thể kết nối đồng thời. 

Công việc 

- Setup GitHub repository và branch workflow. 
- Tạo project ServerApp, ClientApp, Shared. 
- Viết socket server và socket client cơ bản. 
- Xây dựng cơ chế gửi/nhận gói tin JSON đơn giản. 
- Thử nghiệm kết nối 2-3 client với server. 

Kết quả cần đạt 

- Server chạy và nhận kết nối client. 
- Client gửi/nhận gói tin thành công. 
- Có test đơn giản cho multi-client connection. 

Tuần 2 — Protocol giao tiếp và xác thực cơ bản 

Mục tiêu 

- Hoàn thiện giao thức JSON packet cho demo. 
- Xây dựng xác thực đơn giản trên client/server. 

Công việc 

- Định nghĩa packet: LOGIN, STATUS, LOCK, UNLOCK, NOTIFICATION, TIMER, CHAT. 
- Viết parser/handler packet cho server và client. 
- Tạo flow login client và xác thực admin cơ bản. 
- Thêm trạng thái online/offline cho mỗi client. 

Kết quả cần đạt 

- Client login được và server quản lý session. 
- Packet handler xử lý đúng các loại gói demo. 
- Thông tin trạng thái client được đồng bộ hóa. 

Tuần 3 — GUI server & GUI client cơ bản 

Mục tiêu 

- Hoàn thiện giao diện desktop cho server và client. 
- Kết nối GUI với cơ chế networking. 

Công việc 

- Server: Login admin, dashboard, danh sách máy, trạng thái. 
- Client: Connect form, login client, hiển thị trạng thái, nhận thông báo. 
- Giao diện đơn giản, rõ ràng và dễ dùng cho demo. 

Kết quả cần đạt 

- Admin có thể xem danh sách máy realtime. 
- Client có thể connect, đăng nhập và xem lệnh từ server. 
- GUI phản hồi nhanh và không bị treo khi có sự kiện mạng. 

Tuần 4 — Realtime machine status và thông báo 

Mục tiêu 

- Làm cho hệ thống hoạt động realtime đủ tốt cho demo. 

Công việc 

- Đồng bộ trạng thái máy qua TCP/JSON. 
- Hiển thị thông báo admin trên client. 
- Cập nhật trạng thái online/offline, locked, playing. 
- Đảm bảo GUI hiển thị thay đổi tức thì. 

Kết quả cần đạt 

- Server gửi thông báo và client nhận hiển thị. 
- Trạng thái máy cập nhật realtime trong dashboard. 
- Tối thiểu 3 client hoạt động ổn định cùng lúc. 

Tuần 5 — Lock/unlock và session timer 

Mục tiêu 

- Hoàn thiện hai chức năng demo quan trọng: khóa máy và quản lý thời gian. 

Công việc 

- Tạo lệnh lock/unlock từ admin. 
- Thiết kế màn hình khóa client full-screen. 
- Đồng bộ session timer và cập nhật thời gian còn lại. 
- Thử hành vi liên tục khi client bị khóa/mở khóa. 

Kết quả cần đạt 

- Client bị khóa được quản lý bởi server. 
- Timer chạy đúng và client hiển thị thời gian. 
- Trường hợp mất kết nối được xử lý an toàn. 

Tuần 6 — Database nhỏ gọn và ổn định hoá 

Mục tiêu 

- Tích hợp SQLite cho login và lưu cấu hình. 
- Củng cố độ ổn định của hệ thống. 

Công việc 

- Lưu tài khoản admin/client vào SQLite. 
- Thực hiện xác thực login với database. 
- Xây dựng retry/reconnect cơ bản cho client. 
- Thêm logging lỗi đơn giản để dễ debug. 

Kết quả cần đạt 

- Login dựa trên database hoạt động. 
- Server/Client chịu được reconnect nhẹ. 
- Các lỗi mạng không khiến app crash. 

Tuần 7 — Tập trung testing và sửa lỗi 

Mục tiêu 

- Làm cho demo mượt, sửa tất cả lỗi lớn trước buổi trình diễn. 

Công việc 

- Chạy test multi-client, test lock/unlock, test timer. 
- Kiểm tra các trường hợp mất kết nối, đăng xuất, timeout. 
- Làm sạch UI, thông báo lỗi thân thiện. 
- Chuẩn bị kịch bản demo và checklist. 

Kết quả cần đạt 

- Demo flow chính chạy ổn định. 
- Không có crash khi sử dụng tính năng chính. 
- Có checklist “demo-ready” cho nhóm. 

Tuần 8 — Hoàn thiện demo và trình diễn 

Mục tiêu 

- Chuẩn bị bản demo hoàn chỉnh, sẵn sàng chạy trên máy thật. 

Công việc 

- Hoàn thiện nội dung slide/nội dung trình bày. 
- Kiểm tra lần cuối trên cấu hình desktop. 
- Sửa phần còn sót, tối ưu phản hồi GUI. 
- Ghi lại bug nhỏ còn lại và xác nhận demo flow. 

Kết quả cần đạt 

- Hệ thống chạy mượt trong kịch bản demo. 
- Có bản build hoặc project sẵn sàng trình diễn. 
- Nhóm hiểu rõ vai công việc và kịch bản. 

---

Tập trung demo desktop: 
- Bỏ qua file transfer, voice call, video streaming, báo cáo phức tạp hay tính năng mở rộng không cần thiết. 
- Chỉ giữ các chức năng thiết yếu: realtime status, lock/unlock, notifications, timer, chat cơ bản, client/server connect + auth.

GIAI ĐOẠN 5 — LOCK SYSTEM 

Tuần 6 

Mục tiêu 

Xây dựng lock/unlock system. 

Công việc 

Fullscreen lock screen  

Unlock command  

Realtime sync  

Kết quả cần đạt 

Lock/unlock realtime hoạt động  

Milestone 

v0.5-lock-system 

 

GIAI ĐOẠN 6 — DATABASE & AUTH 

Tuần 7 

Mục tiêu 

Tích hợp database. 

Công việc 

SQLite integration  

Account storage  

Login validation  

Session storage  

Kết quả cần đạt 

Login bằng database  

Milestone 

v0.6-database 

 

GIAI ĐOẠN 7 — TESTING & FINAL 

Tuần 8 

Mục tiêu 

Hoàn thiện sản phẩm. 

Công việc 

Bug fixing  

UI optimization  

Multi-client testing  

Documentation  

Slide presentation  

Demo preparation  

Kết quả cần đạt 

Demo hoàn chỉnh  

Milestone 

v1.0-final-release 

 

8. PHÂN CÔNG THÀNH VIÊN 

MEMBER 1 — TEAM LEADER / SYSTEM ARCHITECT 

Nhiệm vụ 

- Điều phối tiến độ tuần, đảm bảo nhóm bám sát milestone. 
- Thiết kế tổng thể, quyết định kiến trúc server/client. 
- Review code chính, kiểm tra tích hợp. 
- Hỗ trợ gỡ nghẽn khi networking hoặc GUI bị chậm. 

Deliverables 

- Roadmap rõ ràng cho 8 tuần. 
- Kiến trúc ServerApp/ClientApp/Shared. 
- Bản build demo ổn định. 

MEMBER 2 — NETWORK ENGINEER 

Nhiệm vụ 

- Xây dựng TCP server và TCP client. 
- Quản lý multi-client, gửi nhận packet chính xác. 
- Thiết kế lại protocol JSON phù hợp demo. 
- Xử lý reconnect, timeout, lỗi socket. 

Deliverables 

- Socket server/client hoạt động. 
- Packet dispatcher, parser/handler. 
- Reconnect/retry cơ bản. 

MEMBER 3 — SERVER GUI DEVELOPER 

Nhiệm vụ 

- Xây dựng admin dashboard desktop. 
- Hiển thị danh sách máy và trạng thái realtime. 
- Triển khai chức năng lock/unlock, gửi notification, trình bày timer. 
- Tối ưu hiển thị để tránh lag khi có nhiều thay đổi. 

Deliverables 

- Server UI cho dashboard demo. 
- Control panel lock/unlock/notify. 
- Machine list realtime hoạt động. 

MEMBER 4 — CLIENT APP DEVELOPER 

Nhiệm vụ 

- Xây dựng client desktop app. 
- Triển khai kết nối IP/Port và xác thực client. 
- Hiển thị thông báo, trạng thái lock, timer. 
- Tạo màn hình khóa full-screen cho client. 

Deliverables 

- Client app kết nối server. 
- Màn hình lock/unlock hoạt động. 
- Hiển thị realtime notification và timer. 

MEMBER 5 — DATABASE & AUTHENTICATION 

Nhiệm vụ 

- Tích hợp SQLite cho quản lý tài khoản. 
- Xây dựng login validation và lưu session. 
- Quản lý cấu hình đơn giản cho client/server. 
- Hỗ trợ server lưu trạng thái user/machine nếu cần. 

Deliverables 

- Database SQLite cơ bản cho demo. 
- Hệ thống login admin/client. 
- Lưu trữ cấu hình và thông tin session. 

MEMBER 6 — TESTER & DOCUMENTATION 

Nhiệm vụ 

- Chạy thử multi-client, test lock/timer/chat. 
- Ghi nhận bug, đề xuất ưu tiên sửa lỗi. 
- Chuẩn bị README ngắn gọn và script demo. 
- Hỗ trợ nhóm trong ngày demo để vận hành mượt. 

Deliverables 

- Test report và danh sách lỗi. 
- Checklist demo-ready. 
- Tài liệu hướng dẫn sử dụng và slide demo. 

---

Quan trọng: nhóm nên tập trung vào việc làm cho các chức năng cốt lõi chạy ổn định, không nên mở rộng thêm tính năng khác cho buổi demo. Các tính năng phụ như file transfer, voice/video, logging nâng cao, báo cáo phân tích có thể bỏ qua để đảm bảo buổi demo không gặp sự cố.
 

9. GITHUB WORKFLOW 

Branch Structure 

main 
develop 
feature/socket 
feature/gui 
feature/chat 
feature/database 
feature/lock-system 

 

Workflow 

feature/* 
   ↓ 
develop 
   ↓ 
main 

 

Commit Convention 

Ví dụ 

[NETWORK] Add TCP server 
[GUI] Add dashboard form 
[DATABASE] Add SQLite login 
[CHAT] Implement realtime chat 

 

10. CÔNG CỤ QUẢN LÍ 

Source Control 

GitHub 

 

Project Management 

GitHub Projects 

 

Communication 

Discord  

Messenger  

Zalo  

 

11. RỦI RO PROJECT 

Networking synchronization 

Thread conflict  

Socket disconnect  

Packet loss  

 

GUI freezing 

Sai async handling  

Blocking thread  

 

Time management 

Scope quá lớn  

Thiếu integration sớm  

 

12. GIẢI PHÁP 

Chia milestone rõ ràng 

Hoàn thành từng giai đoạn  

Không làm dồn cuối kỳ  

 

Networking first 

Làm socket trước GUI  

 

Weekly meeting 

Họp nhóm mỗi tuần  

Review tiến độ  

 

Daily commit 

Commit code thường xuyên  

Tránh conflict lớn  

 

13. TÍNH NĂNG ƯU TIÊN 

HIGH PRIORITY 

TCP connection  

Multi-client  

Realtime machine list  

Notification  

Lock/unlock  

Session timer  

 

MEDIUM PRIORITY 

Chat system  

Logging system  

UI optimization  

 

LOW PRIORITY 

File transfer  

Voice call  

Video streaming  

 

14. KẾT LUẬN 

NetManager là hệ thống quản lí quán net realtime sử dụng mô hình Client-Server với TCP Socket. 

Project phù hợp với môn Lập trình mạng vì: 

sử dụng networking thực tế  

có realtime communication  

có multithreading  

có client-server architecture  

có GUI desktop application  

Hệ thống có khả năng mở rộng thêm nhiều tính năng trong tương lai và phù hợp để sử dụng làm portfolio hoặc đồ án nâng cao sau này. 

 