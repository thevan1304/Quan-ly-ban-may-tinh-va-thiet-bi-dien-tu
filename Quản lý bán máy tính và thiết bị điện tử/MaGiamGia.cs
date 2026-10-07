using System;
using System.Windows.Forms;
using System.Data;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class MaGiamGia : Form
    {
        public MaGiamGia()
        {
            InitializeComponent();
            Load += (sender, args) => TaiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma, ten, ghiChu;
            if (!InputValidation.Required(txtMaGiamGia, "mã giảm giá", 30, out ma)
                || !InputValidation.Required(txtTenChuongTrinh, "tên chương trình", 200, out ten)
                || !InputValidation.Optional(txtGhiChu, "ghi chú", 500, out ghiChu))
                return;

            string loaiGiam = cboLoaiGiam.SelectedItem as string;
            if (string.IsNullOrEmpty(loaiGiam))
            {
                InputValidation.Invalid(cboLoaiGiam, "Vui lòng chọn loại giảm giá.");
                return;
            }

            decimal giaTri = numGiaTriGiam.Value;
            if (giaTri <= 0 || (loaiGiam == "Phần trăm" && giaTri > 100))
            {
                InputValidation.Invalid(numGiaTriGiam,
                    loaiGiam == "Phần trăm" ? "Giá trị giảm phải từ 1 đến 100%." : "Giá trị giảm phải lớn hơn 0.");
                return;
            }

            if (dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date)
            {
                InputValidation.Invalid(dtpNgayKetThuc, "Ngày kết thúc không được trước ngày bắt đầu.");
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                InputValidation.Invalid(numSoLuong, "Số lượng mã phải lớn hơn 0.");
                return;
            }

            string trangThai = cboTrangThai.SelectedItem as string;
            if (string.IsNullOrEmpty(trangThai))
            {
                InputValidation.Invalid(cboTrangThai, "Vui lòng chọn trạng thái.");
                return;
            }

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.MaGiamGia " +
                    "(MaGiamGia, TenChuongTrinh, LoaiGiam, GiaTriGiam, DonToiThieu, GiamToiDa, " +
                    "NgayBatDau, NgayKetThuc, SoLuong, TrangThai, GhiChu) " +
                    "VALUES (@Ma, @Ten, @Loai, @GiaTri, @DonToiThieu, @GiamToiDa, " +
                    "@NgayBatDau, @NgayKetThuc, @SoLuong, @TrangThai, @GhiChu)",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                        parameters.Add("@Loai", SqlDbType.NVarChar, 20).Value = loaiGiam;
                        var value = parameters.Add("@GiaTri", SqlDbType.Decimal);
                        value.Precision = 18;
                        value.Scale = 2;
                        value.Value = giaTri;
                        var minimum = parameters.Add("@DonToiThieu", SqlDbType.Decimal);
                        minimum.Precision = 18;
                        minimum.Scale = 2;
                        minimum.Value = numDonToiThieu.Value;
                        var maximum = parameters.Add("@GiamToiDa", SqlDbType.Decimal);
                        maximum.Precision = 18;
                        maximum.Scale = 2;
                        maximum.Value = numGiamToiDa.Value == 0
                            ? (object)DBNull.Value : numGiamToiDa.Value;
                        parameters.Add("@NgayBatDau", SqlDbType.Date).Value = dtpNgayBatDau.Value.Date;
                        parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = dtpNgayKetThuc.Value.Date;
                        parameters.Add("@SoLuong", SqlDbType.Int).Value = (int)numSoLuong.Value;
                        parameters.Add("@TrangThai", SqlDbType.NVarChar, 30).Value = trangThai;
                        parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value =
                            ghiChu.Length == 0 ? (object)DBNull.Value : ghiChu;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "mã giảm giá"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaGiamGia.Clear();
            txtTenChuongTrinh.Clear();
            cboLoaiGiam.SelectedIndex = -1;
            numGiaTriGiam.Value = 0;
            numDonToiThieu.Value = 0;
            numGiamToiDa.Value = 0;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            numSoLuong.Value = 0;
            cboTrangThai.SelectedIndex = -1;
            txtGhiChu.Clear();
            TaiDanhSach();
            MessageBox.Show("Đã thêm mã giảm giá.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaGiamGia.Focus();
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(dgvMaGiamGia,
                    "SELECT MaGiamGia, TenChuongTrinh, LoaiGiam, GiaTriGiam, DonToiThieu, " +
                    "GiamToiDa, NgayBatDau, NgayKetThuc, SoLuong, TrangThai " +
                    "FROM dbo.MaGiamGia ORDER BY MaGiamGia");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải mã giảm giá: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvMaGiamGia, "mã giảm giá",
                "DELETE FROM dbo.MaGiamGia WHERE MaGiamGia = @Ma", TaiDanhSach);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }
    }
}
