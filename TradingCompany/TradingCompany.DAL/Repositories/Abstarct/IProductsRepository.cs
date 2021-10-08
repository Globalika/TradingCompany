using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;

namespace TradingCompany.DAL.Repositories.Abstract
{
    public interface IProductsRepository : IBaseRepository<Product, ProductFilter>
    {
    }
}