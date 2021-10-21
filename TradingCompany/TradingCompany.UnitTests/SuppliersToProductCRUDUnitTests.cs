using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class SuppliersToProductCRUDUnitTests
    {
        SuppToProdRepository suppToProdRepository = new SuppToProdRepository();
        private SupplierToProduct supplierToProduct = new SupplierToProduct
        {
            ProductId = 2,
            SupplierId = 1
        };
        [TestMethod]
        public void CreateSupplierToProductTest()
        {
            var expectedSupplierToProduct = supplierToProduct;
            suppToProdRepository.Create(expectedSupplierToProduct);
            var actualSupplierToProduct = suppToProdRepository.Get(new SupplierToProductFilter { ProductId = 2, SupplierId = 1 });
            Assert.AreEqual(actualSupplierToProduct.ProductId, expectedSupplierToProduct.ProductId);
            Assert.AreEqual(actualSupplierToProduct.SupplierId, expectedSupplierToProduct.SupplierId);
            suppToProdRepository.Delete(new SupplierToProductFilter { Id = actualSupplierToProduct.Id });
        }
        [TestMethod]
        public void UpdateSupplierToProductTest()
        {
            var expectedSupplierToProduct = new SupplierToProduct
            {
                ProductId = 1,
                SupplierId = 2
            };
            suppToProdRepository.Create(supplierToProduct);
            suppToProdRepository.Update(new SupplierToProduct
            {
                ProductId = 1,
                SupplierId = 2
            },
                new SupplierToProductFilter { ProductId = 2, SupplierId = 1 });
            var actualSupplierToProduct = suppToProdRepository.Get(new SupplierToProductFilter { ProductId = 1, SupplierId = 2 });
            Assert.AreEqual(actualSupplierToProduct.ProductId, expectedSupplierToProduct.ProductId);
            Assert.AreEqual(actualSupplierToProduct.SupplierId, expectedSupplierToProduct.SupplierId);
            suppToProdRepository.Delete(new SupplierToProductFilter { Id = actualSupplierToProduct.Id });
        }
        [TestMethod]
        public void DeleteSupplierToProductTest()
        {
            var expectedRows = suppToProdRepository.GetAll().Count();
            suppToProdRepository.Create(supplierToProduct);
            var tempOrder = suppToProdRepository.Get(new SupplierToProductFilter { ProductId = 2, SupplierId = 1 });
            suppToProdRepository.Delete(new SupplierToProductFilter { Id = tempOrder.Id });
            var actualRows = suppToProdRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
