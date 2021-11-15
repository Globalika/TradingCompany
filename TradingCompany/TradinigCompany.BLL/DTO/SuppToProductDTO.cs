using TradingCompany.DAL.Models.Entities.Impl;

namespace TradingCompany.BLL.DTO
{
    public class SuppToProdDTO
    {
        public ulong Id { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
