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
    }
}
