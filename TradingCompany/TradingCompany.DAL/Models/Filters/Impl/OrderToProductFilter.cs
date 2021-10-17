using System;
using TradingCompany.DAL.Models.Filters.Abstract;

namespace TradingCompany.DAL.Models.Filters.Impl
{
    public class OrderToProductFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public ulong? ProductId { get; set; }
        public ulong? OrderId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? RowInsertTime { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public override string ToString()
        {
            return string.Format("ProductId: {0} \nOrderId: {1} \nQuantity: {2} \nRowInsertTime: {3}\nRowUpdateTime: {4}\n",
                ProductId, OrderId, Quantity, RowInsertTime, RowUpdateTime);
        }
    }
}
