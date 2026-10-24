using System;
using System.Globalization;
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
            IXLCell cell = row.Cell(column);
            if (cell.TryGetValue(out value))
                return value.Date;

            string text = cell.GetString().Trim();
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "MM/dd/yyyy", "M/d/yyyy", "dd/MM/yyyy h:mm:ss tt", "M/d/yyyy h:mm:ss tt" };
            if (DateTime.TryParseExact(text, formats, CultureInfo.InvariantCulture,
                    DateTimeStyles.AllowWhiteSpaces, out value) ||
                DateTime.TryParse(text, CultureInfo.CurrentCulture,
                    DateTimeStyles.AllowWhiteSpaces, out value))
            {
                return value.Date;
            }

            double serial;
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out serial) &&
                serial >= 1 && serial <= 2958465)
            {
                return DateTime.FromOADate(serial).Date;
            }

            throw new FormatException("Ngày ở cột " + column + " không hợp lệ.");
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
