using TradingCompany.DAL.Models.Entities.Abstract;

namespace TradingCompany.DAL.Models.Entities.Impl
{
    public class User : IBaseEntity
    {
        public ulong Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public ulong RoleId { get; set; }

        public override string ToString()
        {
            return string.Format("Id = {0}\nName = {1}\n SurName={2} \nEmail = {3} \nHashPassword = {4}\nRoleId={5}",
                Id, FirstName, LastName, Email, HashPassword, RoleId);
        }

    }
}