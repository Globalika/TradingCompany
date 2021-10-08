using System;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.ConsoleUI.RepoMenu.Impl
{
    class RoleMenu : BaseMenu<RolesRepository, Role, RoleFilter>
    {
        protected override Role InputValues()
        {
            Role role = new Role();
            Console.Write("Name: ");
            role.Name = Console.ReadLine().ToString();
            return role;
        }
    }
}