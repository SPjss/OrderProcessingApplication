using OrderProcessingApplication.Models;

namespace OrderProcessingApplication.Services
{
    public class DiscountService
    {
        public decimal CalculateDiscount(Order order)
        {
            if (order.Amount >= 100 && order.CustomerType == "Loyal")
            {
                return order.Amount * 0.1m;
            }
            return 0;
        }
    }
}
