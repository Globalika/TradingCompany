using System;

namespace TradingCompany.DAL.Models.Entities.Abstract
{
    public interface IBaseEntity
    {
        ulong Id { get; set; }
        DateTime RowInsertTime { get; set; }
        DateTime RowUpdateTime { get; set; }
    }
}
