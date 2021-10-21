using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class SuppliersCRUDUnitTests
    {
        SuppliersRepository suppliersRepository = new SuppliersRepository();
        private Supplier supplier = new Supplier
        {
            Name = "HHH"
        };
        [TestMethod]
        public void CreateSupplierTest()
        {
            var expectedSupplier = supplier;
            suppliersRepository.Create(expectedSupplier);
            var actualSupplier = suppliersRepository.Get(new SupplierFilter { Name = "HHH" });
            Assert.AreEqual(actualSupplier.Name, expectedSupplier.Name);
            suppliersRepository.Delete(new SupplierFilter { Id = actualSupplier.Id });
        }
        [TestMethod]
        public void UpdateSupplierTest()
        {
            var expectedSupplier = new Supplier
            {
                Name = "KKK"
            };
            suppliersRepository.Create(supplier);
            suppliersRepository.Update(new Supplier { Name = "KKK" },
                new SupplierFilter { Name = "HHH" });
            var actualSupplier = suppliersRepository.Get(new SupplierFilter { Name = "KKK" });
            Assert.AreEqual(actualSupplier.Name, expectedSupplier.Name);
            suppliersRepository.Delete(new SupplierFilter { Id = actualSupplier.Id });
        }
        [TestMethod]
        public void DeleteSupplierTest()
        {
            var expectedRows = suppliersRepository.GetAll().Count();
            suppliersRepository.Create(supplier);
            var tempOrder = suppliersRepository.Get(new SupplierFilter { Name = "HHH" });
            suppliersRepository.Delete(new SupplierFilter { Id = tempOrder.Id });
            var actualRows = suppliersRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
