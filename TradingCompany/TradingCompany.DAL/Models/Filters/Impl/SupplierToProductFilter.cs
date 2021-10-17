using System;
using TradingCompany.DAL.Models.Filters.Abstract;

namespace TradingCompany.DAL.Models.Filters.Impl
{
    public class SupplierToProductFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public ulong? SupplierId { get; set; }
        public ulong? ProductId { get; set; }
        public DateTime? RowInsertTime { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public override string ToString()
        {
            return string.Format("SupplierId: {0} \nProductId: {1} \nRowInsertTime: {2}\nRowUpdateTime: {3}\n",
                SupplierId, ProductId, RowInsertTime, RowUpdateTime);
        }
    }
}
