using TradingCompany.DAL.Models.Entities.Impl;

namespace TradingCompany.BLL.DTO
{
    public class UserDTO
    {
        public ulong Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public Role Role { get; set; }

    }
}
