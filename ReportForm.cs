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
            
        }
    }
}