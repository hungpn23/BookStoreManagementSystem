using System;

namespace BookStoreManagementSystem.Models
{
    public class BookRental
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public float DailyFeeAtRental { get; set; }
        public float? TotalFee { get; set; }
        public RentalStatus Status { get; set; }

    }

    public enum RentalStatus
    {
        Renting,  // Đang thuê (giá trị mặc định)
        Returned, // Đã trả
        Overdue   // Quá hạn
    }
}
