using Xunit;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Tests {
    public class OrderDiscountTests {
         [Fact]
        public void LoyalCustomer_WithOrderAbove100_Gets10PercentDiscount()
        {
            // Arrange
            var order = new Order { OrderAmount = 150, CustomerType = "Loyal" };

            // Act
            order.CalculateDiscount();

            // Assert
            Assert.Equal(15, order.Discount);
            Assert.Equal(135, order.FinalAmount);
        }

        [Fact]
        public void NewCustomer_WithOrderAbove100_GetsNoDiscount()
        {
            // Arrange
            var order = new Order { OrderAmount = 150, CustomerType = "New" };

            // Act
            order.CalculateDiscount();

            // Assert
            Assert.Equal(0, order.Discount);
            Assert.Equal(150, order.FinalAmount);
        }

        [Fact]
        public void LoyalCustomer_WithOrderBelow100_GetsNoDiscount()
        {
            // Arrange
            var order = new Order { OrderAmount = 99, CustomerType = "Loyal" };

            // Act
            order.CalculateDiscount();

            // Assert
            Assert.Equal(0, order.Discount);
            Assert.Equal(99, order.FinalAmount);
        }

        [Fact]
        public void LoyalCustomer_WithOrderExactly100_Gets10PercentDiscount()
        {
            // Arrange
            var order = new Order { OrderAmount = 100, CustomerType = "Loyal" };

            // Act
            order.CalculateDiscount();

            // Assert
            Assert.Equal(10, order.Discount);
            Assert.Equal(90, order.FinalAmount);
        }
    }
}