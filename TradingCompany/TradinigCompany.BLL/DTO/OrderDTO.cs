using System;
using TradingCompany.DAL.Models.Entities.Impl;

namespace TradingCompany.BLL.DTO
{
    public class OrderDTO
    {
        public ulong Id { get; set; }

        public User User { get; set; }

        public string Destination { get; set; }

        public DateTime? OrderDate { get; set; }

    }
}
