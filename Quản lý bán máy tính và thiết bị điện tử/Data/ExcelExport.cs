using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data
{
    internal static class ExcelExport
    {
        internal static void ExportGrid(DataGridView grid, string sheetName, string dialogTitle,
            string successLabel)
        {
            int rowCount = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row != null && !row.IsNewRow)
                    rowCount++;
            }

            if (rowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = dialogTitle;
                dialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                dialog.FileName = successLabel + ".xlsx";
                dialog.AddExtension = true;
                dialog.DefaultExt = "xlsx";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        IXLWorksheet sheet = workbook.Worksheets.Add(sheetName);
                        int excelCol = 1;

                        foreach (DataGridViewColumn column in grid.Columns)
                        {
                            if (!column.Visible) continue;
                            sheet.Cell(1, excelCol++).Value = column.HeaderText;
                        }

                        int lastCol = excelCol - 1;
                        if (lastCol > 0)
                        {
                            IXLRange header = sheet.Range(1, 1, 1, lastCol);
                            header.Style.Font.Bold = true;
                            header.Style.Font.FontColor = XLColor.White;
                            header.Style.Fill.BackgroundColor = XLColor.FromArgb(27, 75, 107);
                            header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            header.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        }

                        int excelRow = 2;
                        foreach (DataGridViewRow row in grid.Rows)
                        {
                            if (row == null || row.IsNewRow) continue;
                            excelCol = 1;
                            foreach (DataGridViewColumn column in grid.Columns)
                            {
                                if (!column.Visible) continue;
                                object value = row.Cells[column.Index].Value;
                                sheet.Cell(excelRow, excelCol++).Value =
                                    value == null || value == DBNull.Value ? string.Empty : Convert.ToString(value);
                            }
                            excelRow++;
                        }

                        sheet.Columns().AdjustToContents();
                        sheet.SheetView.FreezeRows(1);
                        workbook.SaveAs(dialog.FileName);
                    }

                    MessageBox.Show("Đã xuất " + rowCount + " dòng ra file Excel.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Không thể xuất Excel: " + error.Message, "Lỗi xuất file",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
