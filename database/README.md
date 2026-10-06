# Cơ sở dữ liệu

Project dùng SQL Server. Trong SQL Server Management Studio (SSMS), bạn có thể chọn một trong hai máy chủ:

- **SQL Server Express:** `TÊN_MÁY_CỦA_BẠN\SQLEXPRESS` hoặc `.\SQLEXPRESS`. Đây là kết nối mặc định trong `App.config`.
- **SQL Server LocalDB:** `(localdb)\MSSQLLocalDB`. Phù hợp khi chạy project trên máy cá nhân.

Sau khi kết nối đến máy chủ bạn chọn, bấm **New Query**, mở file `01_schema.sql` rồi bấm **Execute**. Script tự tạo database `QuanLyBanMayTinh` nếu chưa có, nên bạn không cần tạo database trống trước. Hãy chạy script trên cùng máy chủ mà ứng dụng sẽ kết nối; database ở Express và LocalDB là hai database riêng.

Nếu muốn tự tạo database trống bằng giao diện SSMS: nhấp phải **Databases** → **New Database...** → nhập `QuanLyBanMayTinh` → **OK**. Sau đó vẫn chạy `01_schema.sql` để tạo các bảng và view. Script có thể chạy lại mà không xóa dữ liệu hiện có.

Hoặc chạy **một** lệnh tương ứng từ thư mục gốc project:

SQL Server Express:

```powershell
sqlcmd -S ".\SQLEXPRESS" -E -b -i "database\01_schema.sql"
```

LocalDB:

```powershell
sqlcmd -S "(localdb)\MSSQLLocalDB" -E -b -i "database\01_schema.sql"
```

Script tạo các bảng danh mục, sản phẩm, mã giảm giá, đơn hàng, chi tiết đơn hàng, phiếu bảo hành và hai view phục vụ bảo hành/thống kê. Script không tạo dữ liệu mẫu.

Nếu SSMS vẫn gạch đỏ tên view sau khi Execute báo thành công, chọn **Edit → IntelliSense → Refresh Local Cache** (Ctrl+Shift+R), rồi làm mới mục **Views** trong Object Explorer.

Ứng dụng mặc định kết nối tới `.\SQLEXPRESS` bằng tài khoản Windows. Nếu chọn LocalDB, sửa `Data Source=.\SQLEXPRESS` thành `Data Source=(localdb)\MSSQLLocalDB` trong `App.config`. Sau khi sửa, build lại ứng dụng để cấu hình được sao chép vào thư mục chạy.

Màn hình đơn hàng hiện chưa có phần nhập chi tiết từng sản phẩm; bảng `ChiTietDonHang` được chuẩn bị cho bước hoàn thiện chức năng đó. Các nút giao diện chưa được nối với database ở bước tạo lược đồ này.
