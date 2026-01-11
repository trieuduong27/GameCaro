# Caro LAN Game

**Nhóm:**  
- Bùi Gia Hân  
- Nguyễn Triều Dương  

**Đề tài:**  
Xây dựng game Caro chơi qua mạng LAN sử dụng giao thức **TCP** và **WinForms**

---

## 📌 Giới thiệu

Caro LAN Game là một trò chơi **Caro (Five in a Row)** cho phép **hai người chơi** chơi cùng nhau qua **mạng LAN**.  
Ứng dụng được xây dựng bằng **C# WinForms**, hoạt động với mô hình **Server/Client tự động**:

- Nếu chưa có Server, ứng dụng sẽ tự động trở thành **Server**.  
- Nếu đã có Server, ứng dụng sẽ kết nối như **Client**. :contentReference[oaicite:1]{index=1}

---

## 🎯 Tính năng chính

✔️ Bảng cờ trực quan, có thể **đánh bằng chuột**  
✔️ **Quản lý lượt chơi** giữa hai người  
✔️ **Kiểm tra thắng/thua** theo luật 5 quân liên tiếp  
✔️ **Kết nối mạng LAN dùng giao thức TCP**  
✔️ **Các chức năng menu:**  
  - New Game – bắt đầu ván mới  
  - Undo – quay lại nước trước  
  - Quit – thoát game  
✔️ Thông báo trạng thái: lượt đánh, thắng/thua, kết thúc ván  
✔️ **Đồng bộ dữ liệu** bàn cờ giữa hai máy chơi  

---

## 🛠️ Yêu cầu hệ thống

- Windows 7/8/10/11  
- .NET Framework 4.7.2 trở lên  
- Máy tính kết nối chung **LAN**

---

## 🚀 Cách chạy dự án

1. **Clone repository**  
   ```bash
   git clone https://github.com/trieuduong27/GameCaro.git
##udpade thêm thay đổi ten người chơi
