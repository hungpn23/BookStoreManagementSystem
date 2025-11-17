using BookStoreManagementSystem.Models;
using System;

namespace BookStoreManagementSystem.DataAccess
{
    public class BookRentalSearchCriteria
    {
        public int? CustomerId { get; set; }
        public int? BookId { get; set; }
        public RentalStatus? Status { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}