using TradingCompany.DAL.Models.Entities.Impl;

namespace TradingCompany.BLL.Models
{
    public class SuppToProdViewModel
    {
        public ulong Id { get; set; }
        public string Supplier { get; set; }
        public string Product { get; set; }
    }
}
