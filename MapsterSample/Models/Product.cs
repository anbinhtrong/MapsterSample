using System;

namespace MapsterSample.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
