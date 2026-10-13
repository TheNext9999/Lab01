================================================================================
                    BÁO CÁO VÀ HƯỚNG DẪN BÀI THỰC HÀNH LAB 01
               HỌC PHẦN: LẬP TRÌNH .NET (IT3212) - BỘ MÔN CNTT
================================================================================

I. THÔNG TIN CHUNG
- Trường: Đại học Công nghệ Đông Á
- Khoa: Công nghệ Thông tin - Bộ môn Công nghệ Phần mềm
- Học phần: Lập trình .NET (IT3212)
- Bài tập: Lab 01 - Làm quen Visual Studio và Lập trình Console
- Họ và tên sinh viên: Nguyễn Như An
- Năm sinh: 2006

--------------------------------------------------------------------------------
II. PHẦN BÀI TẬP ĐÃ HOÀN THÀNH
Đã hoàn thành 100% yêu cầu đề bài (10/10 bài tập):

1. Các bài tập có hướng dẫn (Bài 1 -> Bài 5):
   [x] Bài 1: Nhập thông tin cá nhân và tính tuổi gần đúng.
   [x] Bài 2: Tính diện tích xung quanh và thể tích hình trụ.
   [x] Bài 3: Xếp loại kết quả học tập theo thang điểm [0, 10].
   [x] Bài 4: Menu xử lý tính tổng 1..n và in bảng cửu chương 7.
   [x] Bài 5: Xử lý ngoại lệ phép chia (FormatException, DivideByZeroException).

2. Các bài tập tự thực hiện (Bài 6 -> Bài 10):
   [x] Bài 6: Giải phương trình bậc hai ax^2 + bx + c = 0 (xét đầy đủ các trường hợp).
   [x] Bài 7: Thống kê dãy số (Tổng, TBC, Max, Min, đếm số lượng số chẵn).
   [x] Bài 8: Kiểm tra và in danh sách các số nguyên tố <= n.
   [x] Bài 9: Chuyển đổi số nguyên từ 0 đến 99 thành cách đọc tiếng Việt.
   [x] Bài 10: Menu vẽ các hình bằng ký tự * (Tam giác đặc, tam giác rỗng, hình vuông rỗng).

--------------------------------------------------------------------------------
III. BỘ DỮ LIỆU THỬ (TEST DATA) VÀ KẾT QUẢ THỰC THI

* Bài 1: Thông tin cá nhân
  - Dữ liệu vào: Họ tên = "Nguyễn Như An", Năm sinh = 2006
  - Kết quả ra: "Xin chào Nguyễn Như An, tuổi gần đúng: 20"

* Bài 2: Tính toán hình trụ
  - Dữ liệu vào: Bán kính r = 4, Chiều cao h = 6
  - Kết quả ra: Sxq = 150.80; V = 301.59

* Bài 3: Xếp loại học tập
  - Dữ liệu vào: Điểm = 9
  - Kết quả ra: Xếp loại: Xuất sắc

* Bài 4: Menu vòng lặp
  - Lựa chọn 1: n = 2 -> Kết quả: Tổng 1..2 = 3
  - Lựa chọn 2: In bảng cửu chương 7 từ 7 x 1 = 7 đến 7 x 10 = 70

* Bài 5: Xử lý ngoại lệ phép chia
  - Dữ liệu vào: a = 10, b = 2
  - Kết quả ra: a / b = 5. Khối finally xuất ra: "Kết thúc phép tính."

* Bài 6: Giải phương trình bậc hai
  - Dữ liệu vào: a = 4, b = 5, c = 6
  - Kết quả ra: Delta < 0 -> "Phương trình vô nghiệm."

* Bài 7: Thống kê dãy số
  - Dữ liệu vào: n = 5, Dãy số nhập vào = {6, 1, 2, 2, 4}
  - Kết quả ra: 
    + Tổng = 15
    + Trung bình cộng = 3.00
    + Max = 6, Min = 1
    + Số lượng số chẵn = 4

* Bài 8: In danh sách số nguyên tố
  - Dữ liệu vào: n = 5
  - Kết quả ra: Các số nguyên tố <= 5 là: 2 3 5

* Bài 9: Đọc số tiếng Việt
  - Dữ liệu vào: n = 36
  - Kết quả ra: "Cách đọc: Ba mươi sáu"

* Bài 10: Vẽ hình bằng ký tự (*)
  - Dữ liệu vào: Chọn 1 (Tam giác vuông đặc), Kích thước h = 5
  - Kết quả ra: Tam giác vuông đặc gồm 5 dòng ký tự *

--------------------------------------------------------------------------------
IV. HƯỚNG DẪN CÁCH CÀI ĐẶT VÀ CHẠY CHƯƠNG TRÌNH

1. Yêu cầu môi trường:
   - Visual Studio 2022 (đã cài workload ".NET desktop development").
   - .NET Framework 4.8 hoặc .NET 8.

2. Các bước mở và chạy dự án:
   - Bước 1: Giải nén thư mục bài nộp Lab01.
   - Bước 2: Mở tệp Solution (.sln) bằng Visual Studio 2022.
   - Bước 3: Chọn Project muốn chạy (hoặc Project chính chứa Menu điều khiển).
   - Bước 4: Nhấn phím F5 hoặc nút 'Start' trên thanh công cụ để biên dịch và chạy ứng dụng Console.

3. Ghi chú về hiển thị tiếng Việt:
   - Tất cả các file mã nguồn đều đã cấu hình Console.OutputEncoding = Encoding.UTF8 
     để đảm bảo hiển thị đúng font tiếng Việt trên cửa sổ Command Prompt/Console.
================================================================================