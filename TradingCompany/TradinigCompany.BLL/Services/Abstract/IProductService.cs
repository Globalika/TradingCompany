using System.Collections.Generic;
using TradingCompany.BLL.DTO;

namespace TradingCompany.BLL.Services.Abstract
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAll();
        ProductDTO GetById(ulong id);
        bool Create(ProductDTO product);
        bool Update(ProductDTO model);
        bool Delete(ulong id);
        IEnumerable<string> GetProducts();
    }
}
