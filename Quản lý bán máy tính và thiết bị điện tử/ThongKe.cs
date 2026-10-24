using System;
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
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
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
