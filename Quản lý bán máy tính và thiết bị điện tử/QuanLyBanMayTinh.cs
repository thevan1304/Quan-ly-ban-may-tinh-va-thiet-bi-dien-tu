using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class QuanLyBanMayTinh : Form
    {
        private Form trangDangMo = null;

        public QuanLyBanMayTinh()
        {
            InitializeComponent();

            ChonMenu(mnuSanPham);
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            Shown += (sender, args) => TaiDuLieuSanPham();
        }

        // LÀM NỔI BẬT MENU ĐANG ĐƯỢC CHỌN
        private void ChonMenu(ToolStripMenuItem item)
        {
            foreach (ToolStripItem menu in menuStrip1.Items)
            {
                if (menu is ToolStripMenuItem m)
                {
                    m.BackColor = Color.White;
                    m.ForeColor = Color.Black;
                }
            }

            item.BackColor = Color.FromArgb(27, 75, 107);
            item.ForeColor = Color.White;
        }

        // ĐÓNG TRANG CON ĐANG MỞ
        private void DongTrangDangMo()
        {
            if (trangDangMo != null)
            {
                if (!trangDangMo.IsDisposed)
                {
                    trangDangMo.Close();
                }

                trangDangMo = null;
            }
        }

        // QUAY LẠI TRANG SẢN PHẨM
        private void HienTrangSanPham()
        {
            DongTrangDangMo();

            ChonMenu(mnuSanPham);
            TaiDuLieuSanPham();

            // Không cần SetChildIndex.
            // Khi trang con đóng, giao diện Sản phẩm
            // phía dưới sẽ tự hiện lại.
        }

        // MỞ TRANG CON THEO TÊN CLASS
        private void MoTrang(
            string tenForm,
            ToolStripMenuItem menuDuocChon)
        {
            ChonMenu(menuDuocChon);

            DongTrangDangMo();

            string tenDayDu =
                "Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử."
                + tenForm;

            Type loaiForm =
                Assembly.GetExecutingAssembly()
                        .GetType(tenDayDu);

            // Form chưa được tạo
            if (loaiForm == null)
            {
                MessageBox.Show(
                    "Chức năng \"" +
                    menuDuocChon.Text +
                    "\" chưa được tạo.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                HienTrangSanPham();
                return;
            }

            // Kiểm tra class có phải Windows Form
            if (!typeof(Form).IsAssignableFrom(loaiForm))
            {
                MessageBox.Show(
                    tenForm + " không phải là Windows Form.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                HienTrangSanPham();
                return;
            }

            try
            {
                trangDangMo =
                    (Form)Activator.CreateInstance(loaiForm);

                // Biến form thành trang con
                trangDangMo.TopLevel = false;

                trangDangMo.FormBorderStyle =
                    FormBorderStyle.None;

                trangDangMo.WindowState =
                    FormWindowState.Normal;

                // Không Dock.Fill toàn bộ Form chính
                trangDangMo.Dock = DockStyle.None;

                // Form con bắt đầu ngay dưới menu
                trangDangMo.Location =
                    new Point(
                        0,
                        tblMenu.Bottom
                    );

                // Chiếm toàn bộ phần còn lại
                trangDangMo.Size =
                    new Size(
                        this.ClientSize.Width,
                        this.ClientSize.Height - tblMenu.Bottom
                    );

                // Tự co giãn cùng cửa sổ
                trangDangMo.Anchor =
                    AnchorStyles.Top |
                    AnchorStyles.Bottom |
                    AnchorStyles.Left |
                    AnchorStyles.Right;

                this.Controls.Add(trangDangMo);

                trangDangMo.Show();

                trangDangMo.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở trang "
                    + tenForm
                    + ".\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                HienTrangSanPham();
            }
        }

        // SẢN PHẨM
        private void mnuSanPham_Click(
            object sender,
            EventArgs e)
        {
            HienTrangSanPham();
        }

        // DANH MỤC
        private void mnuDanhMuc_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "DanhMuc",
                mnuDanhMuc
            );
        }

        // PHIẾU BẢO HÀNH
        private void mnuBaoHanh_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "BaoHanh",
                mnuBaoHanh
            );
        }

        // MÃ GIẢM GIÁ
        private void mnuMaGiamGia_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "MaGiamGia",
                mnuMaGiamGia
            );
        }

        // ĐƠN HÀNG
        private void mnuDonHang_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "DonHang",
                mnuDonHang
            );
        }

        // THỐNG KÊ DOANH THU
        private void mnuThongKe_Click(
            object sender,
            EventArgs e)
        {
            MoTrang(
                "ThongKe",
                mnuThongKe
            );
        }

        // THOÁT
        private void mnuThoat_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn thoát chương trình?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // NÚT THÊM SẢN PHẨM
        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            string ma, ten;
            decimal giaBan;
            int soLuong;
            if (!InputValidation.Required(txtMaSP, "mã sản phẩm", 30, out ma)
                || !InputValidation.Required(txtTenSP, "tên sản phẩm", 200, out ten))
                return;

            string maDanhMuc = cboDanhMuc.SelectedValue as string;
            if (string.IsNullOrEmpty(maDanhMuc))
            {
                InputValidation.Invalid(cboDanhMuc, "Vui lòng chọn danh mục.");
                return;
            }

            if (!InputValidation.NonNegativeMoney(txtGiaBan, "Giá bán", out giaBan)
                || !InputValidation.NonNegativeInt(txtSoLuong, "Số lượng", out soLuong))
                return;

            try
            {
                Database.Execute(
                    "INSERT INTO dbo.SanPham (MaSanPham, TenSanPham, MaDanhMuc, GiaBan, SoLuong) " +
                    "VALUES (@Ma, @Ten, @DanhMuc, @GiaBan, @SoLuong)",
                    parameters =>
                    {
                        parameters.Add("@Ma", SqlDbType.NVarChar, 30).Value = ma;
                        parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = ten;
                        parameters.Add("@DanhMuc", SqlDbType.NVarChar, 30).Value = maDanhMuc;
                        var price = parameters.Add("@GiaBan", SqlDbType.Decimal);
                        price.Precision = 18;
                        price.Scale = 2;
                        price.Value = giaBan;
                        parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(Database.SaveError(error, "sản phẩm"), "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaSP.Clear();
            txtTenSP.Clear();
            cboDanhMuc.SelectedIndex = -1;
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            TaiDanhSachSanPham();
            MessageBox.Show("Đã thêm sản phẩm.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaSP.Focus();
        }

        private void TaiDuLieuSanPham()
        {
            try
            {
                DataTable danhMuc = Database.Query(
                    "SELECT MaDanhMuc, TenDanhMuc FROM dbo.DanhMuc ORDER BY TenDanhMuc");
                cboDanhMuc.DisplayMember = "TenDanhMuc";
                cboDanhMuc.ValueMember = "MaDanhMuc";
                cboDanhMuc.DataSource = danhMuc;
                cboDanhMuc.SelectedIndex = -1;
                TaiDanhSachSanPham();
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải danh mục: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Database.DeleteSelected(dgvSanPham, "sản phẩm",
                "DELETE FROM dbo.SanPham WHERE MaSanPham = @Ma", TaiDanhSachSanPham);
        }

        private void TaiDanhSachSanPham()
        {
            try
            {
                Database.LoadGrid(dgvSanPham,
                    "SELECT sp.MaSanPham, sp.TenSanPham, dm.TenDanhMuc, sp.GiaBan, sp.SoLuong " +
                    "FROM dbo.SanPham sp JOIN dbo.DanhMuc dm ON dm.MaDanhMuc = sp.MaDanhMuc " +
                    "ORDER BY sp.MaSanPham");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải sản phẩm: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
