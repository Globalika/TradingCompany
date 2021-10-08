using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    class OrderToProductMenu : BaseMenu<OrdersToProductsRepository, OrderToProduct, OrderToProductFilter>
    {
        protected override OrderToProduct InputValues()
        {
            OrderToProduct orderToProduct = new OrderToProduct();
            Console.Write("OrderId: ");
            orderToProduct.OrderId = Convert.ToUInt64(Console.ReadLine().ToString());
            Console.Write("ProductId: ");
            orderToProduct.ProductId = Convert.ToUInt64(Console.ReadLine().ToString());
            Console.Write("Quantity: ");
            orderToProduct.Quantity = Convert.ToInt32(Console.ReadLine().ToString());

            return orderToProduct;
        }
    }
}