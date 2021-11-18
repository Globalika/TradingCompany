using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TradingCompany.BLL.Mapper;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Impl;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLLUnitTests
{
    [TestClass]
    public class OrderServiceUnitTests
    {
        [TestMethod]
        public void CreateOrder()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var mapper = ObjectsMapper.CreateMapper();
            OrderService service = new OrderService(unitOfWork, mapper);

            OrderViewModel order = new OrderViewModel();
            order.Destination = "Ukraine";
            order.OrderDate = new DateTime(2021, 11, 04, 4, 22, 33, DateTimeKind.Local);
            order.User = "2";
            order.Id = 33;
            service.Create(order);
            Assert.IsTrue(service.GetById(33).Equals(order));
        }
        [TestMethod]
        public void DeleteOrder()
        {
        }
    }
}