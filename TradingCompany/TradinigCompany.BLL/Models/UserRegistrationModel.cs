namespace TradingCompany.BLL.Models
{
    public class UserRegistrationModel
    {
        public ulong Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
