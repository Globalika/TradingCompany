using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    class ProductMenu : BaseMenu<ProductsRepository, Product, ProductFilter>
    {
        protected override Product InputValues()
        {
            Product product = new Product();
            Console.Write("Name: ");
            product.Name = Console.ReadLine().ToString();
            Console.Write("Price: ");
            product.Price = Convert.ToInt32(Console.ReadLine().ToString());
            Console.Write("ProducingCountry: ");
            product.ProducingCountry = Console.ReadLine().ToString();
            Console.Write("Brand: ");
            product.Brand = Console.ReadLine().ToString();
            return product;
        }
    }
}
