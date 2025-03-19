using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers {
    public class OrderController : Controller {
        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(Order order) {
            if(order.OrderAmount >= 100 && order.CustomerType =="Loyal") {
                order.Discount = order.OrderAmount * 0.10m;                
            } else {
                order.Discount = 0;
            }

            order.FinalAmount = order.OrderAmount - order.Discount;

            return View("Result", order);
        }
    }
}