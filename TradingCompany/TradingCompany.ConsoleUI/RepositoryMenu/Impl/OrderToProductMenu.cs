using System;
using System.Linq;
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
        public void OutputValues(bool bb)
        {
            OrdersRepository orderRepo = new OrdersRepository();
            var orderList = orderRepo.GetAll();
            ProductsRepository productsRepo = new ProductsRepository();
            var productList = productsRepo.GetAll();
            var orderToProdList = GetAll();
            foreach (var entity in orderToProdList
                .Join(productList, a => a.ProductId, b => b.Id,
                (a, b) => new { a.OrderId, a.Quantity, a.RowInsertTime, a.RowUpdateTime, b.Name, b.Price })
                .Join(orderList, a => a.OrderId, b => b.Id,
                (a, b) => new { a.OrderId, a.Quantity, a.Name, a.RowInsertTime, a.RowUpdateTime, a.Price, b.OrderDate, b.Destination }))
            {
                Console.WriteLine(
                        $"Product Name: {entity.Name}, Order ID: {entity.OrderId}\n" +
                        $"Product Quantity: {entity.Quantity}, Product Price: {entity.Price},\n" +
                        $"OrderTime: {entity.OrderDate}, Destination: {entity.Destination}\n" +
                        $"InsertTime: {entity.RowInsertTime}, UpdateTime: {entity.RowUpdateTime}\n\n");
            }
        }
        public void OutputSelectedValue()
        {
            OrdersRepository orderRepo = new OrdersRepository();
            ProductsRepository productsRepo = new ProductsRepository();
            OrdersToProductsRepository repo = new OrdersToProductsRepository();
            OrderToProductFilter orderToProd = new OrderToProductFilter();
            Console.Write("ID: ");
            orderToProd.OrderId = Convert.ToUInt64(Console.ReadLine().ToString());
            var ordToProd = repo.Get(orderToProd);
            var order = orderRepo.Get(new OrderFilter
            {
                Id = ordToProd.OrderId
            });
            var product = productsRepo.Get(new ProductFilter
            {
                Id = ordToProd.ProductId
            });
            Console.WriteLine(
                   $"Product Name: {product.Name}, Order ID: {orderToProd.OrderId}\n" +
                   $"Product Quantity: {ordToProd.Quantity}, Product Price: {product.Price},\n" +
                   $"OrderTime: {order.OrderDate}, Destination: {order.Destination}\n" +
                   $"InsertTime: {ordToProd.RowInsertTime}, UpdateTime: {ordToProd.RowUpdateTime}\n\n");
        }
        public void OutputSortedValues()
        {
            OrdersRepository orderRepo = new OrdersRepository();
            var orderList = orderRepo.GetAll();
            ProductsRepository productsRepo = new ProductsRepository();
            var productList = productsRepo.GetAll();
            var orderToProdList = GetAll();
            var list = orderToProdList
                .Join(productList, a => a.ProductId, b => b.Id,
                (a, b) => new { a.OrderId, a.Quantity, a.RowInsertTime, a.RowUpdateTime, b.Name, b.Price })
                .Join(orderList, a => a.OrderId, b => b.Id,
                (a, b) => new { a.OrderId, a.Quantity, a.Name, a.RowInsertTime, a.RowUpdateTime, a.Price, b.OrderDate, b.Destination });
            Console.Write("1. ASC 2. DESC: \n");
            int state = Convert.ToInt32(Console.ReadLine());
            switch (state)
            {
                case 1:
                    foreach (var entity in list.OrderBy(a => a.OrderDate))
                    {
                        Console.WriteLine(
                                $"Product Name: {entity.Name}, Order ID: {entity.OrderId}\n" +
                                $"Product Quantity: {entity.Quantity}, Product Price: {entity.Price},\n" +
                                $"OrderTime: {entity.OrderDate}, Destination: {entity.Destination}\n" +
                                $"InsertTime: {entity.RowInsertTime}, UpdateTime: {entity.RowUpdateTime}\n\n");
                    }
                    break;
                default:
                    foreach (var entity in list.OrderByDescending(a => a.OrderDate))
                    {
                        Console.WriteLine(
                                $"Product Name: {entity.Name}, Order ID: {entity.OrderId}\n" +
                                $"Product Quantity: {entity.Quantity}, Product Price: {entity.Price},\n" +
                                $"OrderTime: {entity.OrderDate}, Destination: {entity.Destination}\n" +
                                $"InsertTime: {entity.RowInsertTime}, UpdateTime: {entity.RowUpdateTime}\n\n");
                    }
                    break;
            }
        }
        public void GenerateAReport()
        {
            OrdersRepository orderRepo = new OrdersRepository();
            var orderList = orderRepo.GetAll();
            ProductsRepository productsRepo = new ProductsRepository();
            var productList = productsRepo.GetAll();
            var orderToProdList = GetAll();
            var list = orderToProdList
                .Join(productList, a => a.ProductId, b => b.Id,
                (a, b) => new { a.OrderId, a.Quantity, a.RowInsertTime, a.RowUpdateTime, b.Name, b.Price })
                .Join(orderList, a => a.OrderId, b => b.Id,
                (a, b) => new { a.Quantity, a.Name, a.RowInsertTime, a.RowUpdateTime, a.Price, b.OrderDate, b.Destination });
            Console.Write("Choose start date: \n");
            DateTime start = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Choose end date: \n");
            DateTime end = Convert.ToDateTime(Console.ReadLine());
            var resultList = list.Where(a => start < a.OrderDate && a.OrderDate < end);
            foreach (var entity in resultList)
            {
                Console.WriteLine($"{entity.OrderDate}");
            }
            Console.WriteLine(
                $"\t\t\tReport\n"+
                $"\tTerm: {start} - {end}\n"+
                $"\t\t\tOrders Amount: {resultList.Count()}\n"+
                $"\t\t\tTotal Sum: {resultList.Sum(a => a.Price*a.Quantity)}");
        }
    }
}