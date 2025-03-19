using System.ComponentModel.DataAnnotations;

namespace OrderProcessingApp.Models
{
    public class Order {
        public decimal OrderAmount {get; set;}

        [Required]
        public String CustomerType {get; set;} = "New";

        public decimal Discount {get; set;}
        public decimal FinalAmount {get; set;}
    }
}