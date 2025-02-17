using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Models;
using OrderProcessingApplication.Services;

namespace OrderProcessingApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly DiscountService _discountService;

        public OrderController()
        {
            _discountService = new DiscountService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(Order order)
        {
            decimal discount = _discountService.CalculateDiscount(order);
            decimal finalTotal = order.Amount - discount;

            ViewBag.Discount = discount;
            ViewBag.FinalTotal = finalTotal;

            return View("Result");
        }
    }
}

