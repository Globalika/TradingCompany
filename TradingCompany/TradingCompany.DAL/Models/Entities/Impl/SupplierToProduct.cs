using TradingCompany.DAL.Models.Entities.Abstract;

namespace TradingCompany.DAL.Models.Entities.Impl
{
    public class SupplierToProduct : IBaseEntity
    {
        public ulong Id { get; set; }
        public ulong SupplierId { get; set; }
        public ulong ProductId { get; set; }
        public override string ToString()
        {
            return string.Format("SupplierId: {0} \nProductId: {1} \n",
                SupplierId, ProductId);
        }
    }
}