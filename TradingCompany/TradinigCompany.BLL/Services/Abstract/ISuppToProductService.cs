using System.Collections.Generic;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;

namespace TradingCompany.BLL.Services.Abstract
{
    public interface ISuppToProdService
    {
        IEnumerable<SuppToProdDTO> GetAll();
        IEnumerable<SuppToProdViewModel> GetViewModels();
        SuppToProdDTO GetById(ulong id);
        bool Create(SuppToProdViewModel order);
        bool Update(SuppToProdViewModel order);
        bool Delete(ulong id);
    }
}
