using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class QuanLyBanMayTinh : Form
    {
        private Form trangDangMo = null;

        public QuanLyBanMayTinh()
        {
            InitializeComponent();

            ChonMenu(mnuSanPham);
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

        }
    }
}