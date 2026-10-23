using System;
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
            ExcelExport.ExportGrid(dgvThongKe, "Thống kê doanh thu", "Xuất thống kê doanh thu", "Xuất thống kê doanh thu");
        }
    }
}
