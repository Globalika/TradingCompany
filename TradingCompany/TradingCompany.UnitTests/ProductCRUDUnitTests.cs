using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class ProductCRUDUnitTests
    {
        ProductsRepository productsRepository = new ProductsRepository();
        private Product product = new Product
        {
            Brand = "Fury",
            Name = "Name",
            Price = 333,
            ProducingCountry = "China"
        };
        [TestMethod]
        public void CreateProductTest()
        {
            var expectedProduct = product;
            productsRepository.Create(expectedProduct);
            var actualProduct = productsRepository.Get(new ProductFilter { Brand = "Fury", ProducingCountry = "China" });
            Assert.AreEqual(actualProduct.Brand, expectedProduct.Brand);
            Assert.AreEqual(actualProduct.ProducingCountry, expectedProduct.ProducingCountry);
            productsRepository.Delete(new ProductFilter { Id = actualProduct.Id });
        }
        [TestMethod]
        public void UpdateProductTest()
        {
            var expectedProduct = new Product
            {
                Brand = "Qury",
                Name = "Name",
                Price = 333,
                ProducingCountry = "Japan"
            };
            productsRepository.Create(product);
            productsRepository.Update(new Product { Brand = "Qury", ProducingCountry = "Japan" },
                new ProductFilter { Brand = "Fury", ProducingCountry = "China" });
            var actualProduct = productsRepository.Get(new ProductFilter { Brand = "Qury", ProducingCountry = "Japan" });
            Assert.AreEqual(actualProduct.Brand, expectedProduct.Brand);
            Assert.AreEqual(actualProduct.ProducingCountry, expectedProduct.ProducingCountry);
            productsRepository.Delete(new ProductFilter { Id = actualProduct.Id });
        }
        [TestMethod]
        public void DeleteProductTest()
        {
            var expectedRows = productsRepository.GetAll().Count();
            productsRepository.Create(product);
            var tempOrder = productsRepository.Get(new ProductFilter { Brand = "Fury", ProducingCountry = "China" });
            productsRepository.Delete(new ProductFilter { Id = tempOrder.Id });
            var actualRows = productsRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
