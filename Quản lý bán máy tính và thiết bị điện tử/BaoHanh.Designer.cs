namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class BaoHanh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle styleAlt =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle styleHeader =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle styleCell =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.picBaoHanh = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.grpThongTin = new System.Windows.Forms.GroupBox();

            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();

            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();

            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();

            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();

            this.lblNgayMua = new System.Windows.Forms.Label();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();

            this.lblThoiHan = new System.Windows.Forms.Label();
            this.numThoiHan = new System.Windows.Forms.NumericUpDown();

            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();

            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();

            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.grpTimKiem = new System.Windows.Forms.GroupBox();

            this.lblTimMaPhieu = new System.Windows.Forms.Label();
            this.txtTimMaPhieu = new System.Windows.Forms.TextBox();

            this.lblTimMaSanPham = new System.Windows.Forms.Label();
            this.txtTimMaSanPham = new System.Windows.Forms.TextBox();

            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();

            this.btnTimKiem = new System.Windows.Forms.Button();

            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvBaoHanh = new System.Windows.Forms.DataGridView();

            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.picBaoHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).BeginInit();

            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).BeginInit();

            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.pnlHeader.Controls.Add(this.tblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 105);

            // tblHeader
            this.tblHeader.ColumnCount = 3;

            this.tblHeader.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 50F));

            this.tblHeader.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute, 1150F));

            this.tblHeader.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 50F));

            this.tblHeader.Controls.Add(this.pnlHeaderContent, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            // pnlHeaderContent
            this.pnlHeaderContent.Controls.Add(this.picBaoHanh);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Fill;

            // picBaoHanh
            this.picBaoHanh.Image =
                global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                    .Properties.Resources.warranty;

            this.picBaoHanh.Location =
                new System.Drawing.Point(10, 22);

            this.picBaoHanh.Size =
                new System.Drawing.Size(60, 60);

            this.picBaoHanh.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // lblTitle
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor = System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(85, 18);

            this.lblTitle.Text =
                "QUẢN LÝ PHIẾU BẢO HÀNH";

            // lblSubTitle
            this.lblSubTitle.AutoSize = true;

            this.lblSubTitle.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblSubTitle.ForeColor =
                System.Drawing.Color.FromArgb(210, 225, 235);

            this.lblSubTitle.Location =
                new System.Drawing.Point(88, 65);

            this.lblSubTitle.Text =
                "Quản lý thông tin bảo hành sản phẩm";

            // tblMain
            this.tblMain.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);

            this.tblMain.ColumnCount = 3;

            this.tblMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 50F));

            this.tblMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute, 1150F));

            this.tblMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 50F));

            this.tblMain.Controls.Add(this.pnlContent, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;

            this.tblMain.Location =
                new System.Drawing.Point(0, 105);

            // pnlContent
            this.pnlContent.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);

            this.pnlContent.Controls.Add(this.grpThongTin);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Controls.Add(this.grpTimKiem);
            this.pnlContent.Controls.Add(this.lblDanhSach);
            this.pnlContent.Controls.Add(this.dgvBaoHanh);

            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Margin =
                new System.Windows.Forms.Padding(0, 15, 0, 0);

            // grpThongTin
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Controls.Add(this.txtMaPhieu);

            this.grpThongTin.Controls.Add(this.lblMaSanPham);
            this.grpThongTin.Controls.Add(this.txtMaSanPham);

            this.grpThongTin.Controls.Add(this.lblTenKhachHang);
            this.grpThongTin.Controls.Add(this.txtTenKhachHang);

            this.grpThongTin.Controls.Add(this.lblSoDienThoai);
            this.grpThongTin.Controls.Add(this.txtSoDienThoai);

            this.grpThongTin.Controls.Add(this.lblNgayMua);
            this.grpThongTin.Controls.Add(this.dtpNgayMua);

            this.grpThongTin.Controls.Add(this.lblThoiHan);
            this.grpThongTin.Controls.Add(this.numThoiHan);

            this.grpThongTin.Controls.Add(this.lblNgayHetHan);
            this.grpThongTin.Controls.Add(this.dtpNgayHetHan);

            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.cboTrangThai);

            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);

            this.grpThongTin.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.grpThongTin.ForeColor =
                System.Drawing.Color.FromArgb(27, 75, 107);

            this.grpThongTin.Location =
                new System.Drawing.Point(10, 5);

            this.grpThongTin.Size =
                new System.Drawing.Size(1130, 225);

            this.grpThongTin.Text =
                "THÔNG TIN PHIẾU BẢO HÀNH";

            // Mã phiếu
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblMaPhieu.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblMaPhieu.Location =
                new System.Drawing.Point(20, 38);

            this.lblMaPhieu.Text =
                "Mã phiếu:";

            this.txtMaPhieu.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtMaPhieu.Location =
                new System.Drawing.Point(155, 34);

            this.txtMaPhieu.Size =
                new System.Drawing.Size(390, 25);

            // Mã sản phẩm
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblMaSanPham.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblMaSanPham.Location =
                new System.Drawing.Point(585, 38);

            this.lblMaSanPham.Text =
                "Mã sản phẩm:";

            this.txtMaSanPham.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtMaSanPham.Location =
                new System.Drawing.Point(700, 34);

            this.txtMaSanPham.Size =
                new System.Drawing.Size(390, 25);

            // Khách hàng
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTenKhachHang.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblTenKhachHang.Location =
                new System.Drawing.Point(20, 77);

            this.lblTenKhachHang.Text =
                "Tên khách hàng:";

            this.txtTenKhachHang.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtTenKhachHang.Location =
                new System.Drawing.Point(155, 73);

            this.txtTenKhachHang.Size =
                new System.Drawing.Size(390, 25);

            // SĐT
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblSoDienThoai.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblSoDienThoai.Location =
                new System.Drawing.Point(585, 77);

            this.lblSoDienThoai.Text =
                "Số điện thoại:";

            this.txtSoDienThoai.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtSoDienThoai.Location =
                new System.Drawing.Point(700, 73);

            this.txtSoDienThoai.Size =
                new System.Drawing.Size(390, 25);

            // Ngày mua
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblNgayMua.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblNgayMua.Location =
                new System.Drawing.Point(20, 116);

            this.lblNgayMua.Text =
                "Ngày mua:";

            this.dtpNgayMua.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpNgayMua.Location =
                new System.Drawing.Point(155, 111);

            this.dtpNgayMua.Size =
                new System.Drawing.Size(180, 25);

            // Thời hạn
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblThoiHan.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblThoiHan.Location =
                new System.Drawing.Point(365, 116);

            this.lblThoiHan.Text =
                "Thời hạn (tháng):";

            this.numThoiHan.Location =
                new System.Drawing.Point(475, 111);

            this.numThoiHan.Minimum = 1;
            this.numThoiHan.Maximum = 60;
            this.numThoiHan.Value = 12;

            this.numThoiHan.Size =
                new System.Drawing.Size(70, 25);

            // Ngày hết hạn
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblNgayHetHan.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblNgayHetHan.Location =
                new System.Drawing.Point(585, 116);

            this.lblNgayHetHan.Text =
                "Ngày hết hạn:";

            this.dtpNgayHetHan.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpNgayHetHan.Location =
                new System.Drawing.Point(700, 111);

            this.dtpNgayHetHan.Size =
                new System.Drawing.Size(180, 25);

            // Trạng thái
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTrangThai.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblTrangThai.Location =
                new System.Drawing.Point(20, 155);

            this.lblTrangThai.Text =
                "Trạng thái:";

            this.cboTrangThai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboTrangThai.Items.AddRange(
                new object[]
                {
                    "Còn bảo hành",
                    "Hết bảo hành"
                });

            this.cboTrangThai.Location =
                new System.Drawing.Point(155, 150);

            this.cboTrangThai.Size =
                new System.Drawing.Size(390, 25);

            // Ghi chú
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblGhiChu.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblGhiChu.Location =
                new System.Drawing.Point(585, 155);

            this.lblGhiChu.Text =
                "Ghi chú:";

            this.txtGhiChu.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtGhiChu.Location =
                new System.Drawing.Point(700, 150);

            this.txtGhiChu.Multiline = true;

            this.txtGhiChu.Size =
                new System.Drawing.Size(390, 50);

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);

            this.pnlButtons.Location =
                new System.Drawing.Point(10, 235);

            this.pnlButtons.Size =
                new System.Drawing.Size(1130, 60);

            // btnThem
            this.btnThem.BackColor =
                System.Drawing.Color.FromArgb(20, 156, 110);

            this.btnThem.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnThem.FlatAppearance.BorderSize = 0;

            this.btnThem.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnThem.ForeColor =
                System.Drawing.Color.White;

            this.btnThem.Image =
                new System.Drawing.Bitmap(
                    global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                        .Properties.Resources.add,
                    new System.Drawing.Size(24, 24));

            this.btnThem.Location =
                new System.Drawing.Point(100, 8);

            this.btnThem.Size =
                new System.Drawing.Size(210, 44);

            this.btnThem.Text =
                "   THÊM";

            this.btnThem.TextImageRelation =
                System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.btnThem.Click +=
                new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor =
                System.Drawing.Color.FromArgb(45, 125, 190);

            this.btnSua.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSua.FlatAppearance.BorderSize = 0;

            this.btnSua.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnSua.ForeColor =
                System.Drawing.Color.White;

            this.btnSua.Image =
                new System.Drawing.Bitmap(
                    global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                        .Properties.Resources.edit,
                    new System.Drawing.Size(24, 24));

            this.btnSua.Location =
                new System.Drawing.Point(340, 8);

            this.btnSua.Size =
                new System.Drawing.Size(210, 44);

            this.btnSua.Text =
                "   SỬA";

            this.btnSua.TextImageRelation =
                System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.btnSua.Click +=
                new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor =
                System.Drawing.Color.IndianRed;

            this.btnXoa.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnXoa.FlatAppearance.BorderSize = 0;

            this.btnXoa.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnXoa.ForeColor =
                System.Drawing.Color.White;

            this.btnXoa.Image =
                new System.Drawing.Bitmap(
                    global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                        .Properties.Resources.delete,
                    new System.Drawing.Size(24, 24));

            this.btnXoa.Location =
                new System.Drawing.Point(580, 8);

            this.btnXoa.Size =
                new System.Drawing.Size(210, 44);

            this.btnXoa.Text =
                "   XÓA";

            this.btnXoa.TextImageRelation =
                System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.btnXoa.Click +=
                new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor =
                System.Drawing.Color.Navy;

            this.btnLamMoi.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLamMoi.FlatAppearance.BorderSize = 0;

            this.btnLamMoi.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnLamMoi.ForeColor =
                System.Drawing.Color.White;

            this.btnLamMoi.Image =
                new System.Drawing.Bitmap(
                    global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                        .Properties.Resources.refresh,
                    new System.Drawing.Size(24, 24));

            this.btnLamMoi.Location =
                new System.Drawing.Point(820, 8);

            this.btnLamMoi.Size =
                new System.Drawing.Size(210, 44);

            this.btnLamMoi.Text =
                "   LÀM MỚI";

            this.btnLamMoi.TextImageRelation =
                System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.btnLamMoi.Click +=
                new System.EventHandler(this.btnLamMoi_Click);

            // grpTimKiem
            this.grpTimKiem.Controls.Add(this.lblTimMaPhieu);
            this.grpTimKiem.Controls.Add(this.txtTimMaPhieu);

            this.grpTimKiem.Controls.Add(this.lblTimMaSanPham);
            this.grpTimKiem.Controls.Add(this.txtTimMaSanPham);

            this.grpTimKiem.Controls.Add(this.lblTimKhachHang);
            this.grpTimKiem.Controls.Add(this.txtTimKhachHang);

            this.grpTimKiem.Controls.Add(this.btnTimKiem);

            this.grpTimKiem.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.grpTimKiem.ForeColor =
                System.Drawing.Color.FromArgb(27, 75, 107);

            this.grpTimKiem.Location =
                new System.Drawing.Point(10, 300);

            this.grpTimKiem.Size =
                new System.Drawing.Size(1130, 85);

            this.grpTimKiem.Text =
                "TÌM KIẾM PHIẾU BẢO HÀNH";

            // search mã phiếu
            this.lblTimMaPhieu.AutoSize = true;
            this.lblTimMaPhieu.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTimMaPhieu.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblTimMaPhieu.Location =
                new System.Drawing.Point(20, 38);

            this.lblTimMaPhieu.Text =
                "Mã phiếu:";

            this.txtTimMaPhieu.Location =
                new System.Drawing.Point(90, 34);

            this.txtTimMaPhieu.Size =
                new System.Drawing.Size(180, 25);

            // search mã sản phẩm
            this.lblTimMaSanPham.AutoSize = true;
            this.lblTimMaSanPham.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTimMaSanPham.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblTimMaSanPham.Location =
                new System.Drawing.Point(295, 38);

            this.lblTimMaSanPham.Text =
                "Mã sản phẩm:";

            this.txtTimMaSanPham.Location =
                new System.Drawing.Point(390, 34);

            this.txtTimMaSanPham.Size =
                new System.Drawing.Size(180, 25);

            // search khách hàng
            this.lblTimKhachHang.AutoSize = true;
            this.lblTimKhachHang.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTimKhachHang.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);

            this.lblTimKhachHang.Location =
                new System.Drawing.Point(590, 38);

            this.lblTimKhachHang.Text =
                "Khách hàng:";

            this.txtTimKhachHang.Location =
                new System.Drawing.Point(670, 34);

            this.txtTimKhachHang.Size =
                new System.Drawing.Size(200, 25);

            // btnTimKiem
            this.btnTimKiem.BackColor =
                System.Drawing.Color.FromArgb(7, 156, 170);

            this.btnTimKiem.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.btnTimKiem.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnTimKiem.ForeColor =
                System.Drawing.Color.White;

            this.btnTimKiem.Image =
                new System.Drawing.Bitmap(
                    global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                        .Properties.Resources.search,
                    new System.Drawing.Size(24, 24));

            this.btnTimKiem.Location =
                new System.Drawing.Point(890, 26);

            this.btnTimKiem.Size =
                new System.Drawing.Size(205, 40);

            this.btnTimKiem.Text =
                "   TÌM KIẾM";

            this.btnTimKiem.TextImageRelation =
                System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.btnTimKiem.Click +=
                new System.EventHandler(this.btnTimKiem_Click);

            // lblDanhSach
            this.lblDanhSach.AutoSize = true;

            this.lblDanhSach.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblDanhSach.ForeColor =
                System.Drawing.Color.FromArgb(27, 75, 107);

            this.lblDanhSach.Location =
                new System.Drawing.Point(10, 400);

            this.lblDanhSach.Text =
                "DANH SÁCH PHIẾU BẢO HÀNH";

            // dgvBaoHanh
            this.dgvBaoHanh.AllowUserToAddRows = false;
            this.dgvBaoHanh.AllowUserToDeleteRows = false;
            this.dgvBaoHanh.AllowUserToResizeRows = false;

            styleAlt.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 250);

            this.dgvBaoHanh.AlternatingRowsDefaultCellStyle =
                styleAlt;

            this.dgvBaoHanh.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvBaoHanh.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvBaoHanh.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvBaoHanh.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvBaoHanh.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            styleHeader.BackColor =
                System.Drawing.Color.FromArgb(27, 75, 107);

            styleHeader.ForeColor =
                System.Drawing.Color.White;

            styleHeader.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            styleHeader.SelectionBackColor =
                System.Drawing.Color.FromArgb(27, 75, 107);

            this.dgvBaoHanh.ColumnHeadersDefaultCellStyle =
                styleHeader;

            this.dgvBaoHanh.ColumnHeadersHeight = 38;

            this.dgvBaoHanh.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMaPhieu,
                    this.colMaSanPham,
                    this.colTenKhachHang,
                    this.colSoDienThoai,
                    this.colNgayMua,
                    this.colThoiHan,
                    this.colNgayHetHan,
                    this.colTrangThai
                });

            styleCell.BackColor =
                System.Drawing.Color.White;

            styleCell.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 65);

            styleCell.SelectionBackColor =
                System.Drawing.Color.FromArgb(204, 235, 238);

            styleCell.SelectionForeColor =
                System.Drawing.Color.FromArgb(15, 65, 75);

            this.dgvBaoHanh.DefaultCellStyle =
                styleCell;

            this.dgvBaoHanh.EnableHeadersVisualStyles = false;
            this.dgvBaoHanh.RowHeadersVisible = false;

            this.dgvBaoHanh.Location =
                new System.Drawing.Point(10, 430);

            this.dgvBaoHanh.Size =
                new System.Drawing.Size(1130, 210);

            this.dgvBaoHanh.ReadOnly = true;

            this.dgvBaoHanh.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // columns
            this.colMaPhieu.HeaderText = "Mã phiếu";
            this.colMaPhieu.Name = "colMaPhieu";

            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.Name = "colMaSanPham";

            this.colTenKhachHang.HeaderText = "Khách hàng";
            this.colTenKhachHang.Name = "colTenKhachHang";

            this.colSoDienThoai.HeaderText = "SĐT";
            this.colSoDienThoai.Name = "colSoDienThoai";

            this.colNgayMua.HeaderText = "Ngày mua";
            this.colNgayMua.Name = "colNgayMua";

            this.colThoiHan.HeaderText = "Thời hạn";
            this.colThoiHan.Name = "colThoiHan";

            this.colNgayHetHan.HeaderText = "Ngày hết hạn";
            this.colNgayHetHan.Name = "colNgayHetHan";

            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";

            // BaoHanh
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);

            this.ClientSize =
                new System.Drawing.Size(1200, 800);

            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);

            this.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.MinimumSize =
                new System.Drawing.Size(1200, 800);

            this.Name = "BaoHanh";
            this.Text = "Phiếu bảo hành";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Normal;

            this.pnlHeader.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);

            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.picBaoHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).EndInit();

            this.tblMain.ResumeLayout(false);

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();

            this.pnlButtons.ResumeLayout(false);

            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;

        private System.Windows.Forms.PictureBox picBaoHanh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;

        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;

        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;

        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;

        private System.Windows.Forms.Label lblNgayMua;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;

        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.NumericUpDown numThoiHan;

        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;

        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;

        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Panel pnlButtons;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.GroupBox grpTimKiem;

        private System.Windows.Forms.Label lblTimMaPhieu;
        private System.Windows.Forms.TextBox txtTimMaPhieu;

        private System.Windows.Forms.Label lblTimMaSanPham;
        private System.Windows.Forms.TextBox txtTimMaSanPham;

        private System.Windows.Forms.Label lblTimKhachHang;
        private System.Windows.Forms.TextBox txtTimKhachHang;

        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvBaoHanh;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}