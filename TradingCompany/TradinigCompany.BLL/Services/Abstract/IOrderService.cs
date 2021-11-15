using System.Collections.Generic;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;

namespace TradingCompany.BLL.Services.Abstract
{
    public interface IOrderService
    {
        IEnumerable<OrderDTO> GetAll();
        IEnumerable<OrderViewModel> GetViewModels();
        OrderDTO GetById(ulong id);
        bool Create(OrderViewModel order);
        bool Update(OrderViewModel order);
        bool Delete(ulong id);
    }
}
