# Cơ sở dữ liệu

Project dùng SQL Server. Trong SQL Server Management Studio, kết nối đến SQL Server trên máy của bạn (ví dụ `TÊN_MÁY_CỦA_BẠN\SQLEXPRESS`), bấm **New Query**, mở file `01_schema.sql` rồi bấm **Execute**. Script tự tạo database `QuanLyBanMayTinh` nếu chưa có, nên bạn không cần tạo database trống trước.

Nếu muốn tự tạo database trống bằng giao diện SSMS: nhấp phải **Databases** → **New Database...** → nhập `QuanLyBanMayTinh` → **OK**. Sau đó vẫn chạy `01_schema.sql` để tạo các bảng và view. Script có thể chạy lại mà không xóa dữ liệu hiện có.

Hoặc chạy từ thư mục gốc project bằng dòng lệnh:

```powershell
sqlcmd -S ".\SQLEXPRESS" -E -b -i "database\01_schema.sql"
```

Script tạo các bảng danh mục, sản phẩm, mã giảm giá, đơn hàng, chi tiết đơn hàng, phiếu bảo hành và hai view phục vụ bảo hành/thống kê. Script không tạo dữ liệu mẫu.

Nếu SSMS vẫn gạch đỏ tên view sau khi Execute báo thành công, chọn **Edit → IntelliSense → Refresh Local Cache** (Ctrl+Shift+R), rồi làm mới mục **Views** trong Object Explorer.

Ứng dụng mặc định kết nối tới `.\SQLEXPRESS` bằng tài khoản Windows. Nếu dùng SQL Server instance khác, sửa `Data Source` trong `App.config`. Sau khi sửa, build lại ứng dụng để cấu hình được sao chép vào thư mục chạy.

Màn hình đơn hàng hiện chưa có phần nhập chi tiết từng sản phẩm; bảng `ChiTietDonHang` được chuẩn bị cho bước hoàn thiện chức năng đó. Các nút giao diện chưa được nối với database ở bước tạo lược đồ này.
