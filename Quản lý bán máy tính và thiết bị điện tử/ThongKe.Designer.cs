namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    partial class ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle styleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleCell = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.picThongKe = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.grpBoLoc = new System.Windows.Forms.GroupBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.pnlTongDoanhThu = new System.Windows.Forms.Panel();
            this.lblTongDoanhThuTitle = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();

            this.pnlTongDon = new System.Windows.Forms.Panel();
            this.lblTongDonTitle = new System.Windows.Forms.Label();
            this.lblTongDon = new System.Windows.Forms.Label();

            this.pnlHoanThanh = new System.Windows.Forms.Panel();
            this.lblHoanThanhTitle = new System.Windows.Forms.Label();
            this.lblHoanThanh = new System.Windows.Forms.Label();

            this.pnlDaHuy = new System.Windows.Forms.Panel();
            this.lblDaHuyTitle = new System.Windows.Forms.Label();
            this.lblDaHuy = new System.Windows.Forms.Label();

            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();

            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaHuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThongKe)).BeginInit();

            this.tblMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpBoLoc.SuspendLayout();

            this.pnlTongDoanhThu.SuspendLayout();
            this.pnlTongDon.SuspendLayout();
            this.pnlHoanThanh.SuspendLayout();
            this.pnlDaHuy.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();

            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.pnlHeader.Controls.Add(this.tblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 105);
            this.pnlHeader.TabIndex = 0;

            // tblHeader
            this.tblHeader.ColumnCount = 3;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1150F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblHeader.Controls.Add(this.pnlHeaderContent, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(0, 0);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(1200, 105);

            // pnlHeaderContent
            this.pnlHeaderContent.Controls.Add(this.picThongKe);
            this.pnlHeaderContent.Controls.Add(this.lblTitle);
            this.pnlHeaderContent.Controls.Add(this.lblSubTitle);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderContent.Location = new System.Drawing.Point(25, 0);
            this.pnlHeaderContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderContent.Name = "pnlHeaderContent";
            this.pnlHeaderContent.Size = new System.Drawing.Size(1150, 105);

            // picThongKe
            this.picThongKe.Image = global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Properties.Resources.revenue;
            this.picThongKe.Location = new System.Drawing.Point(10, 22);
            this.picThongKe.Name = "picThongKe";
            this.picThongKe.Size = new System.Drawing.Size(60, 60);
            this.picThongKe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThongKe.TabIndex = 0;
            this.picThongKe.TabStop = false;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "THỐNG KÊ DOANH THU";

            // lblSubTitle
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(210, 225, 235);
            this.lblSubTitle.Location = new System.Drawing.Point(88, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Theo dõi doanh thu và tình hình đơn hàng";

            // tblMain
            this.tblMain.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1150F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.pnlContent, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 105);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1200, 695);

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlContent.Controls.Add(this.grpBoLoc);
            this.pnlContent.Controls.Add(this.pnlTongDoanhThu);
            this.pnlContent.Controls.Add(this.pnlTongDon);
            this.pnlContent.Controls.Add(this.pnlHoanThanh);
            this.pnlContent.Controls.Add(this.pnlDaHuy);
            this.pnlContent.Controls.Add(this.lblDanhSach);
            this.pnlContent.Controls.Add(this.dgvThongKe);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlContent.Name = "pnlContent";

            // grpBoLoc
            this.grpBoLoc.Controls.Add(this.lblTuNgay);
            this.grpBoLoc.Controls.Add(this.dtpTuNgay);
            this.grpBoLoc.Controls.Add(this.lblDenNgay);
            this.grpBoLoc.Controls.Add(this.dtpDenNgay);
            this.grpBoLoc.Controls.Add(this.btnThongKe);
            this.grpBoLoc.Controls.Add(this.btnLamMoi);
            this.grpBoLoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBoLoc.ForeColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.grpBoLoc.Location = new System.Drawing.Point(10, 15);
            this.grpBoLoc.Name = "grpBoLoc";
            this.grpBoLoc.Size = new System.Drawing.Size(1130, 90);
            this.grpBoLoc.TabStop = false;
            this.grpBoLoc.Text = "BỘ LỌC THỐNG KÊ";

            // lblTuNgay
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblTuNgay.Location = new System.Drawing.Point(30, 39);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Text = "Từ ngày:";

            // dtpTuNgay
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(105, 35);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 25);

            // lblDenNgay
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblDenNgay.Location = new System.Drawing.Point(340, 39);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Text = "Đến ngày:";

            // dtpDenNgay
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(425, 35);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 25);

            // btnThongKe
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(7, 156, 170);
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(670, 29);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(190, 42);
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.Navy;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = new System.Drawing.Bitmap(
                global::Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Properties.Resources.refresh,
                new System.Drawing.Size(24, 24));
            this.btnLamMoi.Location = new System.Drawing.Point(885, 29);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(210, 42);
            this.btnLamMoi.Text = "   LÀM MỚI";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // pnlTongDoanhThu
            this.pnlTongDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlTongDoanhThu.Controls.Add(this.lblTongDoanhThuTitle);
            this.pnlTongDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.pnlTongDoanhThu.Location = new System.Drawing.Point(10, 125);
            this.pnlTongDoanhThu.Name = "pnlTongDoanhThu";
            this.pnlTongDoanhThu.Size = new System.Drawing.Size(260, 100);

            this.lblTongDoanhThuTitle.AutoSize = true;
            this.lblTongDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThuTitle.ForeColor = System.Drawing.Color.FromArgb(90, 100, 110);
            this.lblTongDoanhThuTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTongDoanhThuTitle.Name = "lblTongDoanhThuTitle";
            this.lblTongDoanhThuTitle.Text = "TỔNG DOANH THU";

            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(20, 48);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Text = "0 VNĐ";

            // pnlTongDon
            this.pnlTongDon.BackColor = System.Drawing.Color.White;
            this.pnlTongDon.Controls.Add(this.lblTongDonTitle);
            this.pnlTongDon.Controls.Add(this.lblTongDon);
            this.pnlTongDon.Location = new System.Drawing.Point(300, 125);
            this.pnlTongDon.Name = "pnlTongDon";
            this.pnlTongDon.Size = new System.Drawing.Size(260, 100);

            this.lblTongDonTitle.AutoSize = true;
            this.lblTongDonTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongDonTitle.ForeColor = System.Drawing.Color.FromArgb(90, 100, 110);
            this.lblTongDonTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTongDonTitle.Name = "lblTongDonTitle";
            this.lblTongDonTitle.Text = "TỔNG ĐƠN HÀNG";

            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongDon.ForeColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.lblTongDon.Location = new System.Drawing.Point(20, 48);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Text = "0";

            // pnlHoanThanh
            this.pnlHoanThanh.BackColor = System.Drawing.Color.White;
            this.pnlHoanThanh.Controls.Add(this.lblHoanThanhTitle);
            this.pnlHoanThanh.Controls.Add(this.lblHoanThanh);
            this.pnlHoanThanh.Location = new System.Drawing.Point(590, 125);
            this.pnlHoanThanh.Name = "pnlHoanThanh";
            this.pnlHoanThanh.Size = new System.Drawing.Size(260, 100);

            this.lblHoanThanhTitle.AutoSize = true;
            this.lblHoanThanhTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoanThanhTitle.ForeColor = System.Drawing.Color.FromArgb(90, 100, 110);
            this.lblHoanThanhTitle.Location = new System.Drawing.Point(20, 17);
            this.lblHoanThanhTitle.Name = "lblHoanThanhTitle";
            this.lblHoanThanhTitle.Text = "ĐƠN HOÀN THÀNH";

            this.lblHoanThanh.AutoSize = true;
            this.lblHoanThanh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHoanThanh.ForeColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.lblHoanThanh.Location = new System.Drawing.Point(20, 48);
            this.lblHoanThanh.Name = "lblHoanThanh";
            this.lblHoanThanh.Text = "0";

            // pnlDaHuy
            this.pnlDaHuy.BackColor = System.Drawing.Color.White;
            this.pnlDaHuy.Controls.Add(this.lblDaHuyTitle);
            this.pnlDaHuy.Controls.Add(this.lblDaHuy);
            this.pnlDaHuy.Location = new System.Drawing.Point(880, 125);
            this.pnlDaHuy.Name = "pnlDaHuy";
            this.pnlDaHuy.Size = new System.Drawing.Size(260, 100);

            this.lblDaHuyTitle.AutoSize = true;
            this.lblDaHuyTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDaHuyTitle.ForeColor = System.Drawing.Color.FromArgb(90, 100, 110);
            this.lblDaHuyTitle.Location = new System.Drawing.Point(20, 17);
            this.lblDaHuyTitle.Name = "lblDaHuyTitle";
            this.lblDaHuyTitle.Text = "ĐƠN ĐÃ HỦY";

            this.lblDaHuy.AutoSize = true;
            this.lblDaHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDaHuy.ForeColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.lblDaHuy.Location = new System.Drawing.Point(20, 48);
            this.lblDaHuy.Name = "lblDaHuy";
            this.lblDaHuy.Text = "0";

            // lblDanhSach
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(27, 75, 107);
            this.lblDanhSach.Location = new System.Drawing.Point(10, 250);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Text = "CHI TIẾT DOANH THU";

            // dgvThongKe
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            styleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            styleHeader.BackColor = System.Drawing.Color.FromArgb(27, 75, 107);
            styleHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            styleHeader.ForeColor = System.Drawing.Color.White;
            styleHeader.SelectionBackColor = System.Drawing.Color.FromArgb(27, 75, 107);
            styleHeader.SelectionForeColor = System.Drawing.Color.White;
            styleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvThongKe.ColumnHeadersDefaultCellStyle = styleHeader;
            this.dgvThongKe.ColumnHeadersHeight = 38;
            this.dgvThongKe.EnableHeadersVisualStyles = false;

            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNgay,
                this.colSoDon,
                this.colHoanThanh,
                this.colDaHuy,
                this.colDoanhThu
            });

            styleCell.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            styleCell.BackColor = System.Drawing.Color.White;
            styleCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            styleCell.ForeColor = System.Drawing.Color.FromArgb(45, 55, 65);
            styleCell.SelectionBackColor = System.Drawing.Color.FromArgb(204, 235, 238);
            styleCell.SelectionForeColor = System.Drawing.Color.FromArgb(15, 65, 75);

            this.dgvThongKe.DefaultCellStyle = styleCell;
            this.dgvThongKe.Location = new System.Drawing.Point(10, 280);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowTemplate.Height = 32;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1130, 360);

            this.colNgay.HeaderText = "Ngày";
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;

            this.colSoDon.HeaderText = "Số đơn";
            this.colSoDon.Name = "colSoDon";
            this.colSoDon.ReadOnly = true;

            this.colHoanThanh.HeaderText = "Hoàn thành";
            this.colHoanThanh.Name = "colHoanThanh";
            this.colHoanThanh.ReadOnly = true;

            this.colDaHuy.HeaderText = "Đã hủy";
            this.colDaHuy.Name = "colDaHuy";
            this.colDaHuy.ReadOnly = true;

            this.colDoanhThu.HeaderText = "Doanh thu";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;

            // ThongKe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "ThongKe";
            this.Text = "Thống kê doanh thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            this.pnlHeader.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThongKe)).EndInit();

            this.tblMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            this.grpBoLoc.ResumeLayout(false);
            this.grpBoLoc.PerformLayout();

            this.pnlTongDoanhThu.ResumeLayout(false);
            this.pnlTongDoanhThu.PerformLayout();

            this.pnlTongDon.ResumeLayout(false);
            this.pnlTongDon.PerformLayout();

            this.pnlHoanThanh.ResumeLayout(false);
            this.pnlHoanThanh.PerformLayout();

            this.pnlDaHuy.ResumeLayout(false);
            this.pnlDaHuy.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Panel pnlHeaderContent;
        private System.Windows.Forms.PictureBox picThongKe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpBoLoc;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.Panel pnlTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThuTitle;
        private System.Windows.Forms.Label lblTongDoanhThu;

        private System.Windows.Forms.Panel pnlTongDon;
        private System.Windows.Forms.Label lblTongDonTitle;
        private System.Windows.Forms.Label lblTongDon;

        private System.Windows.Forms.Panel pnlHoanThanh;
        private System.Windows.Forms.Label lblHoanThanhTitle;
        private System.Windows.Forms.Label lblHoanThanh;

        private System.Windows.Forms.Panel pnlDaHuy;
        private System.Windows.Forms.Label lblDaHuyTitle;
        private System.Windows.Forms.Label lblDaHuy;

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvThongKe;

        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
    }
}
