using System.ComponentModel.DataAnnotations.Schema;

namespace BuzzardRacing.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }

}

