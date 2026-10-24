using System;
using ClosedXML.Excel;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data
{
    internal static class ExcelImportReader
    {
        internal static string Text(IXLRow row, int column)
        {
            return row.Cell(column).GetString().Trim();
        }

        internal static DateTime Date(IXLRow row, int column)
        {
            DateTime value;
            if (!row.Cell(column).TryGetValue(out value))
            {
                throw new FormatException("Ngày ở cột " + column + " không hợp lệ.");
            }

            return value.Date;
        }

        internal static decimal Decimal(IXLRow row, int column)
        {
            decimal value;
            if (!row.Cell(column).TryGetValue(out value))
            {
                throw new FormatException("Số ở cột " + column + " không hợp lệ.");
            }

            return value;
        }

        internal static decimal? NullableDecimal(IXLRow row, int column)
        {
            if (string.IsNullOrWhiteSpace(row.Cell(column).GetString())) return null;
            return Decimal(row, column);
        }

        internal static int Integer(IXLRow row, int column)
        {
            int value;
            if (!row.Cell(column).TryGetValue(out value))
            {
                throw new FormatException("Số nguyên ở cột " + column + " không hợp lệ.");
            }

            return value;
        }
    }
}
