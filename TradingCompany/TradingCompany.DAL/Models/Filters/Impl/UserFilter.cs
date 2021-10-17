using System;
using TradingCompany.DAL.Models.Filters.Abstract;

namespace TradingCompany.DAL.Models.Filters.Impl
{
    public class UserFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public ulong? RoleId { get; set; }
        public DateTime? RowInsertTime { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public override string ToString()
        {
            return string.Format("Id = {0}\nName = {1}\n SurName={2} \nEmail = {3} \nHashPassword = {4}\nRoleId={5}\nRowInsertTime: {6}\nRowUpdateTime: {7}\n",
                Id, FirstName, LastName, Email, HashPassword, RoleId, RowInsertTime, RowUpdateTime);
        }
    }
}
