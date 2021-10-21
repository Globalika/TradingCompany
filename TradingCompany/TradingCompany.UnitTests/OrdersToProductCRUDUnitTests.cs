using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class OrdersToProductCRUDUnitTests
    {
        OrdersToProductsRepository ordersToProdRepository = new OrdersToProductsRepository();
        private OrderToProduct orderToProduct = new OrderToProduct
        {
            ProductId = 2,
            OrderId = 1,
            Quantity = 5
        };
        [TestMethod]
        public void CreateOrdersToProductTest()
        {
            var expectedorderToProduct = orderToProduct;
            ordersToProdRepository.Create(expectedorderToProduct);
            var actualOrderToProduct = ordersToProdRepository.Get(new OrderToProductFilter { ProductId = 2, OrderId = 1 });
            Assert.AreEqual(actualOrderToProduct.ProductId, expectedorderToProduct.ProductId);
            Assert.AreEqual(actualOrderToProduct.OrderId, expectedorderToProduct.OrderId);
            ordersToProdRepository.Delete(new OrderToProductFilter { Id = actualOrderToProduct.Id });
        }
        [TestMethod]
        public void UpdateOrdersToProductTest()
        {
            var expectedorderToProduct = new OrderToProduct
            {
                ProductId = 1,
                OrderId = 2,
                Quantity = 7
            };
            ordersToProdRepository.Create(orderToProduct);
            ordersToProdRepository.Update(new OrderToProduct
            {
                ProductId = 1,
                OrderId = 2,
                Quantity = 7
            },
                new OrderToProductFilter { ProductId = 2, OrderId = 1 });
            var actualOrderToProduct = ordersToProdRepository.Get(new OrderToProductFilter { ProductId = 1, OrderId = 2 });
            Assert.AreEqual(actualOrderToProduct.ProductId, expectedorderToProduct.ProductId);
            Assert.AreEqual(actualOrderToProduct.OrderId, expectedorderToProduct.OrderId);
            ordersToProdRepository.Delete(new OrderToProductFilter { Id = actualOrderToProduct.Id });
        }
        [TestMethod]
        public void DeleteOrdersToProductTest()
        {
            var expectedRows = ordersToProdRepository.GetAll().Count();
            ordersToProdRepository.Create(orderToProduct);
            var tempOrder = ordersToProdRepository.Get(new OrderToProductFilter { ProductId = 2, OrderId = 1 });
            ordersToProdRepository.Delete(new OrderToProductFilter { Id = tempOrder.Id });
            var actualRows = ordersToProdRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
