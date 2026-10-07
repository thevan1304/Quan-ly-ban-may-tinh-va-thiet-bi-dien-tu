using System;
using System.Windows.Forms;
using System.Data;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
            Load += (sender, args) => TaiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma, ten, moTa;
            if (!InputValidation.Required(txtMaDanhMuc, "mã danh mục", 30, out ma)
                || !InputValidation.Required(txtTenDanhMuc, "tên danh mục", 150, out ten)
                || !InputValidation.Optional(txtMoTa, "mô tả", 500, out moTa))
                return;

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.DanhMuc (MaDanhMuc, TenDanhMuc, MoTa) VALUES (@Ma, @Ten, @MoTa)",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 150).Value = ten;
                        parameters.Add("@MoTa", SqlDbType.NVarChar, 500).Value =
                            moTa.Length == 0 ? (object)DBNull.Value : moTa;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "danh mục"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMoTa.Clear();
            TaiDanhSach();
            MessageBox.Show("Đã thêm danh mục.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaDanhMuc.Focus();
        }

        private void TaiDanhSach()
        {
            try
            {
                Database.LoadGrid(dgvDanhMuc,
                    "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM dbo.DanhMuc ORDER BY MaDanhMuc");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải danh mục: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvDanhMuc, "danh mục",
                "DELETE FROM dbo.DanhMuc WHERE MaDanhMuc = @Ma", TaiDanhSach);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
