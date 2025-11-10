using System;

namespace BookStoreManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float DailyRentalFee { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Type { get; set; }
        public int AuthorId { get; set; }
        public int? CurrentCustomerId { get; set; }
    }
}

