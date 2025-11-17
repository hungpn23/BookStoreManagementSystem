using BookStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookStoreManagementSystem.Forms
{
    public partial class RentalReportForm : Form
    {
        public RentalReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm (public) để nhận (data) từ MainForm
        /// </summary>
        public void LoadReport(List<RentalReportViewModel> dataSource)
        {
            try
            {
                // 1. Tạo một (instance) của file báo cáo (file .rpt bạn đã tạo)
                // (Visual Studio sẽ tự động tạo class 'RentalReport' khi bạn tạo 'RentalReport.rpt')
                RentalReport rpt = new RentalReport();

                // 2. Gán nguồn dữ liệu (List<T>) cho báo cáo
                rpt.SetDataSource(dataSource);

                // 3. Gán báo cáo cho (Viewer)
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi báo cáo");
            }
        }
    }
}