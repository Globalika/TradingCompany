using System;

namespace TradingCompany.BLL.Models
{
    public class OrderViewModel
    {
        public ulong Id { get; set; }

        public string User { get; set; }

        public string Destination { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}
