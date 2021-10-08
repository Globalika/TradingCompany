using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    public class UserMenu : BaseMenu<UsersRepository, User, UserFilter>
    {
        protected override User InputValues()
        {
            User user = new User();
            Console.Write("Name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Surname: ");
            user.LastName = Console.ReadLine();
            Console.Write("Email: ");
            user.Email = Console.ReadLine().ToString();
            Console.Write("RoleID: ");
            user.RoleId = Convert.ToUInt64(Console.ReadLine());
            Console.Write("HashPassword: ");
            user.HashPassword = Console.ReadLine().ToString();
            return user;
        }
    }
}
