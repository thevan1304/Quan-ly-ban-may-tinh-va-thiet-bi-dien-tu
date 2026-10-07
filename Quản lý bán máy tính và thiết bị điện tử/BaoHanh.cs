using System;
using System.Windows.Forms;
using System.Data;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class BaoHanh : Form
    {
        public BaoHanh()
        {
            InitializeComponent();
            dtpNgayHetHan.Enabled = false;
            cboTrangThai.Enabled = false;
            dtpNgayMua.ValueChanged += (sender, args) => CapNhatNgayHetHan();
            numThoiHan.ValueChanged += (sender, args) => CapNhatNgayHetHan();
            CapNhatNgayHetHan();
            Load += (sender, args) => TaiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieu, maSanPham, khachHang, soDienThoai, ghiChu;
            if (!InputValidation.Required(txtMaPhieu, "mã phiếu", 30, out maPhieu)
                || !InputValidation.Required(txtMaSanPham, "mã sản phẩm", 30, out maSanPham)
                || !InputValidation.Required(txtTenKhachHang, "tên khách hàng", 150, out khachHang)
                || !InputValidation.Optional(txtSoDienThoai, "số điện thoại", 20, out soDienThoai)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            DateTime ngayMua = dtpNgayMua.Value.Date;
            int thoiHan = (int)numThoiHan.Value;
            DateTime ngayHetHan = ngayMua.AddMonths(thoiHan);

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.BaoHanh " +
                    "(MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, NgayMua, ThoiHan, NgayHetHan, GhiChu) " +
                    "VALUES (@MaPhieu, @MaSanPham, @KhachHang, @SoDienThoai, @NgayMua, @ThoiHan, @NgayHetHan, @GhiChu)",
                    parameters =>
                    {
                        parameters.Add("@MaPhieu", SqlDbType.NVarChar, 30).Value = maPhieu;
                        parameters.Add("@MaSanPham", SqlDbType.NVarChar, 30).Value = maSanPham;
                        parameters.Add("@KhachHang", SqlDbType.NVarChar, 150).Value = khachHang;
                        parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                            soDienThoai.Length == 0 ? (object)DBNull.Value : soDienThoai;
                        parameters.Add("@NgayMua", SqlDbType.Date).Value = ngayMua;
                        parameters.Add("@ThoiHan", SqlDbType.Int).Value = thoiHan;
                        parameters.Add("@NgayHetHan", SqlDbType.Date).Value = ngayHetHan;
                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0 ? (object)DBNull.Value : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "phiếu bảo hành"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaPhieu.Clear();
            txtMaSanPham.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtGhiChu.Clear();
            dtpNgayMua.Value = DateTime.Today;
            numThoiHan.Value = 12;
            CapNhatNgayHetHan();
            TaiDanhSach();
            MessageBox.Show("Đã thêm phiếu bảo hành.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaPhieu.Focus();
        }

        private void CapNhatNgayHetHan()
        {
            DateTime ngayHetHan = dtpNgayMua.Value.Date.AddMonths((int)numThoiHan.Value);
            dtpNgayHetHan.Value = ngayHetHan;
            cboTrangThai.SelectedItem = ngayHetHan >= DateTime.Today
                ? "Còn bảo hành" : "Hết bảo hành";
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(dgvBaoHanh,
                    "SELECT MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, " +
                    "NgayMua, ThoiHan, NgayHetHan, TrangThai " +
                    "FROM dbo.vwBaoHanh ORDER BY MaPhieu");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải phiếu bảo hành: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvBaoHanh, "phiếu bảo hành",
                "DELETE FROM dbo.BaoHanh WHERE MaPhieu = @Ma", TaiDanhSach);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
