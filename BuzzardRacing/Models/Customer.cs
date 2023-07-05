namespace BuzzardRacing.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // Unique identifier for the customer
        public string Name { get; set; } // Name of the customer
        public List<Order> Orders { get; set; } // List of orders placed by the customer

    }
}
