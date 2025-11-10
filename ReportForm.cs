// Thêm các using này
using BookStoreManagementSystem.Models;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm public để nhận dữ liệu và file báo cáo
        /// </summary>
        public void LoadReport(List<Book> dataSource)
        {
            try
            {
                // 1. Tạo một instance của file báo cáo bạn đã thiết kế
                BookReport rpt = new BookReport();

                // 2. Gán nguồn dữ liệu (List<Book>) cho báo cáo
                rpt.SetDataSource(dataSource);

                // 3. Gán báo cáo cho Viewer
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }
    }
}