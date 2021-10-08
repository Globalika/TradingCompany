using System;
using TradingCompany.DAL.Models.Entities.Abstract;

namespace TradingCompany.DAL.Models.Entities.Impl
{
    public class Order : IBaseEntity
    {
        public ulong Id { get; set; }

        public ulong UserId { get; set; }

        public string Destination { get; set; }

        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} \nUserId: {1} \nDestination: {2} \nOrderDate: {3}\n",
                Id, UserId, Destination, OrderDate);
        }
    }
}