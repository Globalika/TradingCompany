using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    class OrderMenu : BaseMenu<OrdersRepository, Order, OrderFilter>
    {
        protected override Order InputValues()
        {
            Order order = new Order();
            Console.Write("Destination: ");
            order.UserId = Convert.ToUInt64(Console.ReadLine().ToString());
            Console.Write("OrderDate: ");
            order.OrderDate = Convert.ToDateTime(Console.ReadLine().ToString());

            return order;
        }
    }
}