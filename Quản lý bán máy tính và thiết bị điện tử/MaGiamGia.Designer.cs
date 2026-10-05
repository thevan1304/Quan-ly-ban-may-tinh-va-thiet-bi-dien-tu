namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class MaGiamGia
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
            this.picGiamGia = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.grpThongTin = new System.Windows.Forms.GroupBox();

            this.lblMaGiamGia = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();

            this.lblTenChuongTrinh = new System.Windows.Forms.Label();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();

            this.lblLoaiGiam = new System.Windows.Forms.Label();
            this.cboLoaiGiam = new System.Windows.Forms.ComboBox();

            this.lblGiaTriGiam = new System.Windows.Forms.Label();
            this.numGiaTriGiam = new System.Windows.Forms.NumericUpDown();

            this.lblDonToiThieu = new System.Windows.Forms.Label();
            this.numDonToiThieu = new System.Windows.Forms.NumericUpDown();

            this.lblGiamToiDa = new System.Windows.Forms.Label();
            this.numGiamToiDa = new System.Windows.Forms.NumericUpDown();

            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();

            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();

            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();

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

            this.lblTimMa = new System.Windows.Forms.Label();
            this.txtTimMa = new System.Windows.Forms.TextBox();

            this.lblTimTen = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();

            this.lblTimTrangThai = new System.Windows.Forms.Label();
            this.cboTimTrangThai = new System.Windows.Forms.ComboBox();

            this.btnTimKiem = new System.Windows.Forms.Button();

            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvMaGiamGia = new System.Windows.Forms.DataGridView();

            this.colMaGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTriGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.picGiamGia)).BeginInit();

            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongTin.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.numGiaTriGiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();

            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMaGiamGia)).BeginInit();

            this.SuspendLayout();

            // =========================================================
            // pnlHeader
            // =========================================================
            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(27, 75, 107);

            this.pnlHeader.Controls.Add(this.tblHeader);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name = "pnlHeader";

            this.pnlHeader.Size =
                new System.Drawing.Size(1200, 105);

            // =========================================================
            // tblHeader
            // =========================================================
            this.tblHeader.ColumnCount = 3;

            this.tblHeader.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    50F));

            this.tblHeader.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    1150F));

            this.tblHeader.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    50F));

            this.tblHeader.Controls.Add(
                this.pnlHeaderContent,
                1,
                0);

            this.tblHeader.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.tblHeader.RowCount = 1;

            this.tblHeader.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent,
                    100F));

            // =========================================================
            // pnlHeaderContent
            // =========================================================
            this.pnlHeaderContent.Controls.Add(this.picGiamGia);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);

            this.pnlHeaderContent.Dock =
                System.Windows.Forms.DockStyle.Fill;

            // =========================================================
            // picGiamGia
            // =========================================================
            this.picGiamGia.Image =
                global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
                .Properties.Resources.discount;

            this.picGiamGia.Location =
                new System.Drawing.Point(10, 22);

            this.picGiamGia.Name = "picGiamGia";

            this.picGiamGia.Size =
                new System.Drawing.Size(60, 60);

            this.picGiamGia.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picGiamGia.TabStop = false;

            // =========================================================
            // lblTitle
            // =========================================================
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(85, 18);

            this.lblTitle.Text =
                "QUẢN LÝ MÃ GIẢM GIÁ";

            // =========================================================
            // lblSubTitle
            // =========================================================
            this.lblSubTitle.AutoSize = true;

            this.lblSubTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblSubTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    210,
                    225,
                    235);

            this.lblSubTitle.Location =
                new System.Drawing.Point(88, 65);

            this.lblSubTitle.Text =
                "Quản lý chương trình khuyến mãi và mã giảm giá";

            // =========================================================
            // tblMain
            // =========================================================
            this.tblMain.BackColor =
                System.Drawing.Color.FromArgb(
                    241,
                    245,
                    249);

            this.tblMain.ColumnCount = 3;

            this.tblMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    50F));

            this.tblMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    1150F));

            this.tblMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    50F));

            this.tblMain.Controls.Add(
                this.pnlContent,
                1,
                0);

            this.tblMain.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.tblMain.Location =
                new System.Drawing.Point(0, 105);

            this.tblMain.RowCount = 1;

            this.tblMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent,
                    100F));

            // =========================================================
            // pnlContent
            // =========================================================
            this.pnlContent.BackColor =
                System.Drawing.Color.FromArgb(
                    241,
                    245,
                    249);

            this.pnlContent.Controls.Add(this.grpThongTin);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Controls.Add(this.grpTimKiem);
            this.pnlContent.Controls.Add(this.lblDanhSach);
            this.pnlContent.Controls.Add(this.dgvMaGiamGia);

            this.pnlContent.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlContent.Margin =
                new System.Windows.Forms.Padding(
                    0,
                    15,
                    0,
                    0);

            // =========================================================
            // grpThongTin
            // =========================================================
            this.grpThongTin.Controls.Add(this.lblMaGiamGia);
            this.grpThongTin.Controls.Add(this.txtMaGiamGia);

            this.grpThongTin.Controls.Add(this.lblTenChuongTrinh);
            this.grpThongTin.Controls.Add(this.txtTenChuongTrinh);

            this.grpThongTin.Controls.Add(this.lblLoaiGiam);
            this.grpThongTin.Controls.Add(this.cboLoaiGiam);

            this.grpThongTin.Controls.Add(this.lblGiaTriGiam);
            this.grpThongTin.Controls.Add(this.numGiaTriGiam);

            this.grpThongTin.Controls.Add(this.lblDonToiThieu);
            this.grpThongTin.Controls.Add(this.numDonToiThieu);

            this.grpThongTin.Controls.Add(this.lblGiamToiDa);
            this.grpThongTin.Controls.Add(this.numGiamToiDa);

            this.grpThongTin.Controls.Add(this.lblNgayBatDau);
            this.grpThongTin.Controls.Add(this.dtpNgayBatDau);

            this.grpThongTin.Controls.Add(this.lblNgayKetThuc);
            this.grpThongTin.Controls.Add(this.dtpNgayKetThuc);

            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.numSoLuong);

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
                System.Drawing.Color.FromArgb(
                    27,
                    75,
                    107);

            this.grpThongTin.Location =
                new System.Drawing.Point(10, 5);

            this.grpThongTin.Size =
                new System.Drawing.Size(1130, 250);

            this.grpThongTin.Text =
                "THÔNG TIN MÃ GIẢM GIÁ";

            // =========================================================
            // Dòng 1 - Mã giảm giá
            // =========================================================
            this.lblMaGiamGia.AutoSize = true;

            this.lblMaGiamGia.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblMaGiamGia.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblMaGiamGia.Location =
                new System.Drawing.Point(20, 38);

            this.lblMaGiamGia.Text =
                "Mã giảm giá:";

            this.txtMaGiamGia.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtMaGiamGia.Location =
                new System.Drawing.Point(155, 34);

            this.txtMaGiamGia.Size =
                new System.Drawing.Size(390, 25);

            // =========================================================
            // Tên chương trình
            // =========================================================
            this.lblTenChuongTrinh.AutoSize = true;

            this.lblTenChuongTrinh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTenChuongTrinh.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblTenChuongTrinh.Location =
                new System.Drawing.Point(585, 38);

            this.lblTenChuongTrinh.Text =
                "Tên chương trình:";

            this.txtTenChuongTrinh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtTenChuongTrinh.Location =
                new System.Drawing.Point(700, 34);

            this.txtTenChuongTrinh.Size =
                new System.Drawing.Size(390, 25);

            // =========================================================
            // Loại giảm
            // =========================================================
            this.lblLoaiGiam.AutoSize = true;

            this.lblLoaiGiam.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblLoaiGiam.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblLoaiGiam.Location =
                new System.Drawing.Point(20, 77);

            this.lblLoaiGiam.Text =
                "Loại giảm:";

            this.cboLoaiGiam.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLoaiGiam.Items.AddRange(
                new object[]
                {
                    "Phần trăm",
                    "Số tiền"
                });

            this.cboLoaiGiam.Location =
                new System.Drawing.Point(155, 73);

            this.cboLoaiGiam.Size =
                new System.Drawing.Size(180, 25);

            // =========================================================
            // Giá trị giảm
            // =========================================================
            this.lblGiaTriGiam.AutoSize = true;

            this.lblGiaTriGiam.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblGiaTriGiam.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblGiaTriGiam.Location =
                new System.Drawing.Point(365, 77);

            this.lblGiaTriGiam.Text =
                "Giá trị giảm:";

            this.numGiaTriGiam.DecimalPlaces = 0;

            this.numGiaTriGiam.Maximum =
                new decimal(
                    new int[]
                    {
                        1000000000,
                        0,
                        0,
                        0
                    });

            this.numGiaTriGiam.Location =
                new System.Drawing.Point(455, 73);

            this.numGiaTriGiam.Size =
                new System.Drawing.Size(90, 25);

            // =========================================================
            // Đơn tối thiểu
            // =========================================================
            this.lblDonToiThieu.AutoSize = true;

            this.lblDonToiThieu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblDonToiThieu.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblDonToiThieu.Location =
                new System.Drawing.Point(585, 77);

            this.lblDonToiThieu.Text =
                "Đơn tối thiểu:";

            this.numDonToiThieu.Maximum =
                new decimal(
                    new int[]
                    {
                        1000000000,
                        0,
                        0,
                        0
                    });

            this.numDonToiThieu.Location =
                new System.Drawing.Point(700, 73);

            this.numDonToiThieu.Size =
                new System.Drawing.Size(180, 25);

            // =========================================================
            // Giảm tối đa
            // =========================================================
            this.lblGiamToiDa.AutoSize = true;

            this.lblGiamToiDa.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblGiamToiDa.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblGiamToiDa.Location =
                new System.Drawing.Point(900, 77);

            this.lblGiamToiDa.Text =
                "Giảm tối đa:";

            this.numGiamToiDa.Maximum =
                new decimal(
                    new int[]
                    {
                        1000000000,
                        0,
                        0,
                        0
                    });

            this.numGiamToiDa.Location =
                new System.Drawing.Point(990, 73);

            this.numGiamToiDa.Size =
                new System.Drawing.Size(100, 25);

            // =========================================================
            // Ngày bắt đầu
            // =========================================================
            this.lblNgayBatDau.AutoSize = true;

            this.lblNgayBatDau.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblNgayBatDau.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblNgayBatDau.Location =
                new System.Drawing.Point(20, 116);

            this.lblNgayBatDau.Text =
                "Ngày bắt đầu:";

            this.dtpNgayBatDau.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpNgayBatDau.Location =
                new System.Drawing.Point(155, 111);

            this.dtpNgayBatDau.Size =
                new System.Drawing.Size(180, 25);

            // =========================================================
            // Ngày kết thúc
            // =========================================================
            this.lblNgayKetThuc.AutoSize = true;

            this.lblNgayKetThuc.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblNgayKetThuc.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblNgayKetThuc.Location =
                new System.Drawing.Point(365, 116);

            this.lblNgayKetThuc.Text =
                "Ngày kết thúc:";

            this.dtpNgayKetThuc.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpNgayKetThuc.Location =
                new System.Drawing.Point(455, 111);

            this.dtpNgayKetThuc.Size =
                new System.Drawing.Size(180, 25);

            // =========================================================
            // Số lượng
            // =========================================================
            this.lblSoLuong.AutoSize = true;

            this.lblSoLuong.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblSoLuong.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblSoLuong.Location =
                new System.Drawing.Point(665, 116);

            this.lblSoLuong.Text =
                "Số lượng:";

            this.numSoLuong.Maximum =
                new decimal(
                    new int[]
                    {
                        1000000,
                        0,
                        0,
                        0
                    });

            this.numSoLuong.Location =
                new System.Drawing.Point(735, 111);

            this.numSoLuong.Size =
                new System.Drawing.Size(145, 25);

            // =========================================================
            // Trạng thái
            // =========================================================
            this.lblTrangThai.AutoSize = true;

            this.lblTrangThai.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTrangThai.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblTrangThai.Location =
                new System.Drawing.Point(900, 116);

            this.lblTrangThai.Text =
                "Trạng thái:";

            this.cboTrangThai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboTrangThai.Items.AddRange(
                new object[]
                {
                    "Đang hoạt động",
                    "Chưa bắt đầu",
                    "Đã hết hạn",
                    "Tạm khóa"
                });

            this.cboTrangThai.Location =
                new System.Drawing.Point(990, 111);

            this.cboTrangThai.Size =
                new System.Drawing.Size(100, 25);

            // =========================================================
            // Ghi chú
            // =========================================================
            this.lblGhiChu.AutoSize = true;

            this.lblGhiChu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblGhiChu.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblGhiChu.Location =
                new System.Drawing.Point(20, 158);

            this.lblGhiChu.Text =
                "Ghi chú:";

            this.txtGhiChu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtGhiChu.Location =
                new System.Drawing.Point(155, 151);

            this.txtGhiChu.Multiline = true;

            this.txtGhiChu.Size =
                new System.Drawing.Size(935, 70);

            // =========================================================
            // pnlButtons
            // =========================================================
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);

            this.pnlButtons.Location =
                new System.Drawing.Point(10, 260);

            this.pnlButtons.Size =
                new System.Drawing.Size(1130, 60);

            // =========================================================
            // btnThem
            // =========================================================
            this.btnThem.BackColor =
                System.Drawing.Color.FromArgb(
                    20,
                    156,
                    110);

            this.btnThem.FlatAppearance.BorderSize = 0;

            this.btnThem.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

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

            this.btnThem.UseVisualStyleBackColor = false;

            this.btnThem.Click +=
                new System.EventHandler(this.btnThem_Click);

            // =========================================================
            // btnSua
            // =========================================================
            this.btnSua.BackColor =
                System.Drawing.Color.FromArgb(
                    45,
                    125,
                    190);

            this.btnSua.FlatAppearance.BorderSize = 0;

            this.btnSua.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

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

            this.btnSua.UseVisualStyleBackColor = false;

            this.btnSua.Click +=
                new System.EventHandler(this.btnSua_Click);

            // =========================================================
            // btnXoa
            // =========================================================
            this.btnXoa.BackColor =
                System.Drawing.Color.IndianRed;

            this.btnXoa.FlatAppearance.BorderSize = 0;

            this.btnXoa.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

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

            this.btnXoa.UseVisualStyleBackColor = false;

            this.btnXoa.Click +=
                new System.EventHandler(this.btnXoa_Click);

            // =========================================================
            // btnLamMoi
            // =========================================================
            this.btnLamMoi.BackColor =
                System.Drawing.Color.Navy;

            this.btnLamMoi.FlatAppearance.BorderSize = 0;

            this.btnLamMoi.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

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

            this.btnLamMoi.UseVisualStyleBackColor = false;

            this.btnLamMoi.Click +=
                new System.EventHandler(this.btnLamMoi_Click);

            // =========================================================
            // grpTimKiem
            // =========================================================
            this.grpTimKiem.Controls.Add(this.lblTimMa);
            this.grpTimKiem.Controls.Add(this.txtTimMa);

            this.grpTimKiem.Controls.Add(this.lblTimTen);
            this.grpTimKiem.Controls.Add(this.txtTimTen);

            this.grpTimKiem.Controls.Add(this.lblTimTrangThai);
            this.grpTimKiem.Controls.Add(this.cboTimTrangThai);

            this.grpTimKiem.Controls.Add(this.btnTimKiem);

            this.grpTimKiem.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.grpTimKiem.ForeColor =
                System.Drawing.Color.FromArgb(
                    27,
                    75,
                    107);

            this.grpTimKiem.Location =
                new System.Drawing.Point(10, 325);

            this.grpTimKiem.Size =
                new System.Drawing.Size(1130, 85);

            this.grpTimKiem.Text =
                "TÌM KIẾM MÃ GIẢM GIÁ";

            // =========================================================
            // Tìm mã
            // =========================================================
            this.lblTimMa.AutoSize = true;

            this.lblTimMa.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTimMa.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblTimMa.Location =
                new System.Drawing.Point(20, 38);

            this.lblTimMa.Text =
                "Mã giảm giá:";

            this.txtTimMa.Location =
                new System.Drawing.Point(105, 34);

            this.txtTimMa.Size =
                new System.Drawing.Size(180, 25);

            // =========================================================
            // Tìm tên
            // =========================================================
            this.lblTimTen.AutoSize = true;

            this.lblTimTen.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTimTen.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblTimTen.Location =
                new System.Drawing.Point(305, 38);

            this.lblTimTen.Text =
                "Tên chương trình:";

            this.txtTimTen.Location =
                new System.Drawing.Point(420, 34);

            this.txtTimTen.Size =
                new System.Drawing.Size(250, 25);

            // =========================================================
            // Tìm trạng thái
            // =========================================================
            this.lblTimTrangThai.AutoSize = true;

            this.lblTimTrangThai.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTimTrangThai.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    65,
                    81);

            this.lblTimTrangThai.Location =
                new System.Drawing.Point(690, 38);

            this.lblTimTrangThai.Text =
                "Trạng thái:";

            this.cboTimTrangThai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboTimTrangThai.Items.AddRange(
                new object[]
                {
                    "Tất cả",
                    "Đang hoạt động",
                    "Chưa bắt đầu",
                    "Đã hết hạn",
                    "Tạm khóa"
                });

            this.cboTimTrangThai.Location =
                new System.Drawing.Point(760, 34);

            this.cboTimTrangThai.Size =
                new System.Drawing.Size(140, 25);

            // =========================================================
            // btnTimKiem
            // =========================================================
            this.btnTimKiem.BackColor =
                System.Drawing.Color.FromArgb(
                    7,
                    156,
                    170);

            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.btnTimKiem.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

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
                new System.Drawing.Point(920, 26);

            this.btnTimKiem.Size =
                new System.Drawing.Size(175, 40);

            this.btnTimKiem.Text =
                "   TÌM KIẾM";

            this.btnTimKiem.TextImageRelation =
                System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.btnTimKiem.UseVisualStyleBackColor = false;

            this.btnTimKiem.Click +=
                new System.EventHandler(this.btnTimKiem_Click);

            // =========================================================
            // lblDanhSach
            // =========================================================
            this.lblDanhSach.AutoSize = true;

            this.lblDanhSach.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblDanhSach.ForeColor =
                System.Drawing.Color.FromArgb(
                    27,
                    75,
                    107);

            this.lblDanhSach.Location =
                new System.Drawing.Point(10, 425);

            this.lblDanhSach.Text =
                "DANH SÁCH MÃ GIẢM GIÁ";

            // =========================================================
            // dgvMaGiamGia
            // =========================================================
            this.dgvMaGiamGia.AllowUserToAddRows = false;
            this.dgvMaGiamGia.AllowUserToDeleteRows = false;
            this.dgvMaGiamGia.AllowUserToResizeRows = false;

            styleAlt.BackColor =
                System.Drawing.Color.FromArgb(
                    245,
                    249,
                    250);

            this.dgvMaGiamGia.AlternatingRowsDefaultCellStyle =
                styleAlt;

            this.dgvMaGiamGia.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvMaGiamGia.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvMaGiamGia.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvMaGiamGia.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvMaGiamGia.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            styleHeader.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            styleHeader.BackColor =
                System.Drawing.Color.FromArgb(
                    27,
                    75,
                    107);

            styleHeader.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            styleHeader.ForeColor =
                System.Drawing.Color.White;

            styleHeader.SelectionBackColor =
                System.Drawing.Color.FromArgb(
                    27,
                    75,
                    107);

            styleHeader.SelectionForeColor =
                System.Drawing.Color.White;

            this.dgvMaGiamGia.ColumnHeadersDefaultCellStyle =
                styleHeader;

            this.dgvMaGiamGia.ColumnHeadersHeight = 38;

            this.dgvMaGiamGia.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMaGiamGia,
                    this.colTenChuongTrinh,
                    this.colLoaiGiam,
                    this.colGiaTriGiam,
                    this.colDonToiThieu,
                    this.colGiamToiDa,
                    this.colNgayBatDau,
                    this.colNgayKetThuc,
                    this.colSoLuong,
                    this.colTrangThai
                });

            styleCell.BackColor =
                System.Drawing.Color.White;

            styleCell.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            styleCell.ForeColor =
                System.Drawing.Color.FromArgb(
                    45,
                    55,
                    65);

            styleCell.SelectionBackColor =
                System.Drawing.Color.FromArgb(
                    204,
                    235,
                    238);

            styleCell.SelectionForeColor =
                System.Drawing.Color.FromArgb(
                    15,
                    65,
                    75);

            this.dgvMaGiamGia.DefaultCellStyle =
                styleCell;

            this.dgvMaGiamGia.EnableHeadersVisualStyles = false;

            this.dgvMaGiamGia.Location =
                new System.Drawing.Point(10, 455);

            this.dgvMaGiamGia.MultiSelect = false;

            this.dgvMaGiamGia.ReadOnly = true;

            this.dgvMaGiamGia.RowHeadersVisible = false;

            this.dgvMaGiamGia.RowTemplate.Height = 32;

            this.dgvMaGiamGia.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvMaGiamGia.Size =
                new System.Drawing.Size(1130, 185);

            // =========================================================
            // Columns
            // =========================================================
            this.colMaGiamGia.HeaderText =
                "Mã giảm giá";

            this.colMaGiamGia.Name =
                "colMaGiamGia";

            this.colTenChuongTrinh.HeaderText =
                "Tên chương trình";

            this.colTenChuongTrinh.Name =
                "colTenChuongTrinh";

            this.colLoaiGiam.HeaderText =
                "Loại giảm";

            this.colLoaiGiam.Name =
                "colLoaiGiam";

            this.colGiaTriGiam.HeaderText =
                "Giá trị";

            this.colGiaTriGiam.Name =
                "colGiaTriGiam";

            this.colDonToiThieu.HeaderText =
                "Đơn tối thiểu";

            this.colDonToiThieu.Name =
                "colDonToiThieu";

            this.colGiamToiDa.HeaderText =
                "Giảm tối đa";

            this.colGiamToiDa.Name =
                "colGiamToiDa";

            this.colNgayBatDau.HeaderText =
                "Ngày bắt đầu";

            this.colNgayBatDau.Name =
                "colNgayBatDau";

            this.colNgayKetThuc.HeaderText =
                "Ngày kết thúc";

            this.colNgayKetThuc.Name =
                "colNgayKetThuc";

            this.colSoLuong.HeaderText =
                "Số lượng";

            this.colSoLuong.Name =
                "colSoLuong";

            this.colTrangThai.HeaderText =
                "Trạng thái";

            this.colTrangThai.Name =
                "colTrangThai";

            // =========================================================
            // MaGiamGia
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    241,
                    245,
                    249);

            this.ClientSize =
                new System.Drawing.Size(1200, 800);

            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.MinimumSize =
                new System.Drawing.Size(1200, 800);

            this.Name =
                "MaGiamGia";

            this.Text =
                "Quản lý mã giảm giá";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Normal;

            this.pnlHeader.ResumeLayout(false);

            this.tblHeader.ResumeLayout(false);

            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.picGiamGia)).EndInit();

            this.tblMain.ResumeLayout(false);

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.numGiaTriGiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();

            this.pnlButtons.ResumeLayout(false);

            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMaGiamGia)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;

        private System.Windows.Forms.PictureBox picGiamGia;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblMaGiamGia;
        private System.Windows.Forms.TextBox txtMaGiamGia;

        private System.Windows.Forms.Label lblTenChuongTrinh;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;

        private System.Windows.Forms.Label lblLoaiGiam;
        private System.Windows.Forms.ComboBox cboLoaiGiam;

        private System.Windows.Forms.Label lblGiaTriGiam;
        private System.Windows.Forms.NumericUpDown numGiaTriGiam;

        private System.Windows.Forms.Label lblDonToiThieu;
        private System.Windows.Forms.NumericUpDown numDonToiThieu;

        private System.Windows.Forms.Label lblGiamToiDa;
        private System.Windows.Forms.NumericUpDown numGiamToiDa;

        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;

        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;

        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;

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

        private System.Windows.Forms.Label lblTimMa;
        private System.Windows.Forms.TextBox txtTimMa;

        private System.Windows.Forms.Label lblTimTen;
        private System.Windows.Forms.TextBox txtTimTen;

        private System.Windows.Forms.Label lblTimTrangThai;
        private System.Windows.Forms.ComboBox cboTimTrangThai;

        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.Label lblDanhSach;

        private System.Windows.Forms.DataGridView dgvMaGiamGia;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTriGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}