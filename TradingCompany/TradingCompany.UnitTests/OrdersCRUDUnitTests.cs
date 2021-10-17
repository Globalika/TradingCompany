using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.IO;
using TradingCompany.DAL.Core;
using TradingCompany.DAL.Database;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class OrdersCRUDUnitTests
    {
        private string connString;
        private Order order;
        private OrdersRepository ordersRepository;
        private DbManager dbManager;
        [TestInitialize]
        public void TestInitialize()
        {
            dbManager = new DbManager();
            this.connString = ConfigurationManager.ConnectionStrings["TEST_DATABASE"].ConnectionString;
            dbManager.CreateConnection(connString);
            string path = System.IO.Path.GetFullPath(@"..\..\..\TradingCompany.DAL\Database\create_tables.sql");
            string script = File.ReadAllText(path);
            using (SqlConnection conn = new SqlConnection(this.connStr))
            using (SqlCommand command = conn.CreateCommand())
            {
                command.CommandText = $"INSERT INTO ROLES (ROLENAME) VALUES ({entity.Name});";
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                return entity;
            }
            dbManager.ExecuteNonQuery(script);
            this.order = new Order();
            this.ordersRepository = new OrdersRepository();
        }
        [TestCleanup]
        public void TestCleanUp()
        {
        }
        [TestMethod]
        public void CreateOrderTest()
        {
           
            ordersRepository.Create(new Order
            {
                UserId = 1,
                Destination = "Ukraine",
                OrderDate = new DateTime(2021,11,04,4,22,33,DateTimeKind.Local)
            });

        }
    }
}
