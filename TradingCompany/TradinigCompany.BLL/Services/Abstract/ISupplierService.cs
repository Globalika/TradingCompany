using System.Collections.Generic;
using TradingCompany.BLL.DTO;

namespace TradingCompany.BLL.Services.Abstract
{
    public interface ISupplierService
    {
        IEnumerable<SupplierDTO> GetAll();
        SupplierDTO GetById(ulong id);
        bool Create(SupplierDTO model);
        bool Update(SupplierDTO model);
        bool Delete(ulong id);
        IEnumerable<string> GetSupplierByProduct(string product);
    }
}
