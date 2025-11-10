using BookStoreManagementSystem.Models;

namespace BookStoreManagementSystem.DataAccess
{
    public class BookRentalSearchCriteria
    {
        public int? CustomerId { get; set; }
        public int? BookId { get; set; }
        public RentalStatus? Status { get; set; }
    }
}