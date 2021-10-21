using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class OrdersCRUDUnitTests
    {
        OrdersRepository ordersRepository = new OrdersRepository();
        private Order order = new Order
        {
            UserId = 2,
            Destination = "Ukraine",
            OrderDate = new DateTime(2021, 11, 04, 4, 22, 33, DateTimeKind.Local)
        };
        [TestMethod]
        public void CreateOrderTest()
        {
            var expectedOrder = order;
            ordersRepository.Create(expectedOrder);
            var actualOrder = ordersRepository.Get(new OrderFilter { UserId = 2, Destination = "Ukraine" });
            Assert.AreEqual(actualOrder.UserId, expectedOrder.UserId);
            Assert.AreEqual(actualOrder.Destination, expectedOrder.Destination);
            ordersRepository.Delete(new OrderFilter { Id = actualOrder.Id });
        }
        [TestMethod]
        public void UpdateOrderTest()
        {
            var expectedOrder = new Order
            {
                UserId = 2,
                Destination = "France"
            };
            ordersRepository.Create(order);
            ordersRepository.Update(new Order { UserId = 2, Destination = "France" },
                new OrderFilter { UserId = 2, Destination = "Ukraine" });
            var actualOrder = ordersRepository.Get(new OrderFilter { UserId = 2, Destination = "France" });
            Assert.AreEqual(actualOrder.UserId, expectedOrder.UserId);
            Assert.AreEqual(actualOrder.Destination, expectedOrder.Destination);
            ordersRepository.Delete(new OrderFilter { Id = actualOrder.Id });
        }
        [TestMethod]
        public void DeleteOrderTest()
        {
            var expectedRows = ordersRepository.GetAll().Count();
            ordersRepository.Create(order);
            var tempOrder = ordersRepository.Get(new OrderFilter { UserId = 2, Destination = "Ukraine" });
            ordersRepository.Delete(new OrderFilter { Id = tempOrder.Id });
            var actualRows = ordersRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
