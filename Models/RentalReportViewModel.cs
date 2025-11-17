using System;

namespace BookStoreManagementSystem.Models
{
    // Lớp này dùng để làm "khuôn" cho Crystal Reports
    // (Đã sửa lỗi Nullable)
    public class RentalReportViewModel
    {
        public string book_name { get; set; }
        public string customer_name { get; set; }
        public DateTime rental_date { get; set; }
        public DateTime due_date { get; set; }

        // SỬA: Chuyển từ DateTime? sang string
        public string actual_return_date { get; set; }

        public float daily_fee_at_rental { get; set; }

        // SỬA: Chuyển từ float? sang string
        public string total_fee { get; set; }

        public string status { get; set; }
    }
}