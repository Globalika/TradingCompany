using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    public class SupplierToProductMenu : BaseMenu<SuppToProdRepository, SupplierToProduct, SupplierToProductFilter>
    {
        protected override SupplierToProduct InputValues()
        {
            SupplierToProduct supplierToProduct = new SupplierToProduct();
            Console.Write("ProductId: ");
            supplierToProduct.ProductId = Convert.ToUInt64(Console.ReadLine());
            Console.Write("SupplierId: ");
            supplierToProduct.SupplierId = Convert.ToUInt64(Console.ReadLine());
            return supplierToProduct;
        }
    }
}
