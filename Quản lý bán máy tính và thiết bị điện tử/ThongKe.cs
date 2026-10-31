using System;
using System.Data;
using ClosedXML.Excel;
using System.Windows.Forms;
using Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;
            Load += (sender, args) => ThucHienThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;
            dgvThongKe.Rows.Clear();
            CapNhatTongHop(0, 0, 0, 0);
            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;
            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Khoảng thời gian không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable data = Database.Query(
                    "SELECT Ngay, SoDon, HoanThanh, DaHuy, DoanhThu " +
                    "FROM dbo.vwDoanhThuNgay " +
                    "WHERE Ngay BETWEEN @TuNgay AND @DenNgay ORDER BY Ngay",
                    parameters =>
                    {
                        parameters.Add("@TuNgay", SqlDbType.Date).Value = tuNgay;
                        parameters.Add("@DenNgay", SqlDbType.Date).Value = denNgay;
                    });

                dgvThongKe.Rows.Clear();
                int tongDon = 0;
                int tongHoanThanh = 0;
                int tongDaHuy = 0;
                decimal tongDoanhThu = 0;

                foreach (DataRow row in data.Rows)
                {
                    DateTime ngay = Convert.ToDateTime(row["Ngay"]).Date;
                    int soDon = Convert.ToInt32(row["SoDon"]);
                    int hoanThanh = Convert.ToInt32(row["HoanThanh"]);
                    int daHuy = Convert.ToInt32(row["DaHuy"]);
                    decimal doanhThu = row["DoanhThu"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DoanhThu"]);

                    dgvThongKe.Rows.Add(ngay, soDon, hoanThanh, daHuy, doanhThu);
                    tongDon += soDon;
                    tongHoanThanh += hoanThanh;
                    tongDaHuy += daHuy;
                    tongDoanhThu += doanhThu;
                }

                CapNhatTongHop(tongDoanhThu, tongDon, tongHoanThanh, tongDaHuy);
            }
            catch (Exception error)
            {
                MessageBox.Show("Không thể tải thống kê: " + error.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatTongHop(decimal tongDoanhThu, int tongDon, int tongHoanThanh, int tongDaHuy)
        {
            lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " VNĐ";
            lblTongDon.Text = tongDon.ToString("N0");
            lblHoanThanh.Text = tongHoanThanh.ToString("N0");
            lblDaHuy.Text = tongDaHuy.ToString("N0");
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            int soDong = 0;
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if (row == null || row.IsNewRow) continue;
                soDong++;
            }

            if (soDong == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê để xuất Excel.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Xuất thống kê doanh thu";
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.AddExtension = true;
                dialog.FileName = "ThongKeDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    XuatDanhSachExcel(dialog.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Không thể xuất Excel: " + error.Message, "Lỗi xuất file",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Đã xuất " + soDong + " dòng thống kê ra file Excel.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XuatDanhSachExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Thống kê doanh thu");
                int excelColumn = 1;

                foreach (DataGridViewColumn column in dgvThongKe.Columns)
                {
                    if (!column.Visible)
                        continue;

                    sheet.Cell(1, excelColumn).Value = column.HeaderText;
                    excelColumn++;
                }

                int lastColumn = excelColumn - 1;
                if (lastColumn == 0)
                    return;

                IXLRange header = sheet.Range(1, 1, 1, lastColumn);
                header.Style.Font.Bold = true;
                header.Style.Font.FontColor = XLColor.White;
                header.Style.Fill.BackgroundColor = XLColor.FromArgb(27, 75, 107);
                header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                header.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                sheet.Row(1).Height = 22;

                int excelRow = 2;
                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    if (row == null || row.IsNewRow)
                        continue;

                    excelColumn = 1;
                    foreach (DataGridViewColumn column in dgvThongKe.Columns)
                    {
                        if (!column.Visible)
                            continue;

                        object value = row.Cells[column.Index].Value;
                        IXLCell cell = sheet.Cell(excelRow, excelColumn);
                        cell.Value = value == null ? string.Empty : value.ToString();

                        if (value is DateTime)
                            cell.Style.DateFormat.Format = "dd/MM/yyyy";

                        excelColumn++;
                    }

                    excelRow++;
                }

                sheet.Columns().AdjustToContents();
                sheet.SheetView.FreezeRows(1);
                workbook.SaveAs(filePath);
            }
        }

    }
}
