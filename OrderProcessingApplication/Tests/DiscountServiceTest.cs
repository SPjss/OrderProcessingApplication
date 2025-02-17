using Xunit;
using OrderProcessingApplication.Models;
using OrderProcessingApplication.Services;

namespace OrderProcessingApplication.Tests
{
    public class DiscountServiceTest
    {
        [Fact]
        public void CalculatesDiscount_ForLoyalCustomer()
        {
            var service = new DiscountService();
            var order = new Order { Amount = 100, CustomerType = "Loyal" };
            decimal discount = service.CalculateDiscount(order);
            Assert.Equal(10, discount);
        }
    }
}

