namespace TradingCompany.BLL.Models
{
    public class UserViewModel
    {
        public ulong Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public string Role { get; set; }

    }
}
