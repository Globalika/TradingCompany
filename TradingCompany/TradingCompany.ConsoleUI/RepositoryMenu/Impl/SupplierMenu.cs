using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    class SupplierMenu : BaseMenu<SuppliersRepository, Supplier, SupplierFilter>
    {
        protected override Supplier InputValues()
        {
            Supplier supplier = new Supplier();
            Console.Write("Name: ");
            supplier.Name = Console.ReadLine().ToString();
            return supplier;
        }
    }
}