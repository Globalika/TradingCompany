using TradingCompany.DAL.Models.Filters.Abstract;

namespace TradingCompany.DAL.Models.Filters.Impl
{
    public class SupplierToProductFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public ulong? SupplierId { get; set; }
        public ulong? ProductId { get; set; }
        public override string ToString()
        {
            return string.Format("SupplierId: {0} \nProductId: {1} \n",
                SupplierId, ProductId);
        }
    }
}
