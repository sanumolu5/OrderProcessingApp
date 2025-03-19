using System.ComponentModel.DataAnnotations;

namespace OrderProcessingApp.Models
{
    public class Order {
        [Range(1, double.MaxValue, ErrorMessage = "Order amount must be greater than 0")]
        public decimal OrderAmount {get; set;}

        [Required]
        public String CustomerType {get; set;} = "New";

        public decimal Discount {get; set;}
        public decimal FinalAmount {get; set;}

        // Discount calculation
        public void CalculateDiscount() {
             if (OrderAmount >= 100 && CustomerType == "Loyal")
            {
                Discount = OrderAmount * 0.10m;
            }
            else
            {
                Discount = 0;
            }
            FinalAmount = OrderAmount - Discount;
        }
    }
}