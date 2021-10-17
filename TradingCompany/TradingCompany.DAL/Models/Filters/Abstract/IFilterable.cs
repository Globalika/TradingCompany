using System;

namespace TradingCompany.DAL.Models.Filters.Abstract
{
    public interface IFilterable
    {
        ulong? Id { get; set; }
        DateTime? RowInsertTime { get; set; }
        DateTime? RowUpdateTime { get; set; }
    }
}
