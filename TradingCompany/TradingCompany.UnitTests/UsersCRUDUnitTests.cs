using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class UsersCRUDUnitTests
    {
        UsersRepository usersRepository = new UsersRepository();
        private User user = new User
        {
            RoleId = 2,
            Email = "ff@gmaiil.com",
            FirstName = "Hello",
            LastName = "There",
            HashPassword = "dppddppd"
        };
        [TestMethod]
        public void CreateUserTest()
        {
            var expectedUser = user;
            usersRepository.Create(expectedUser);
            var actualUser = usersRepository.Get(new UserFilter { FirstName = "Hello", LastName = "There" });
            Assert.AreEqual(actualUser.FirstName, expectedUser.FirstName);
            Assert.AreEqual(actualUser.LastName, expectedUser.LastName);
            usersRepository.Delete(new UserFilter { Id = actualUser.Id });
        }
        [TestMethod]
        public void UpdateUserTest()
        {
            var expectedUser = new User
            {
                RoleId = 2,
                Email = "ff@gmaiil.com",
                FirstName = "Hey",
                LastName = "Hey",
                HashPassword = "dppddppd"
            };
            usersRepository.Create(user);
            usersRepository.Update(new User {
                RoleId = 2,
                Email = "ff@gmaiil.com",
                FirstName = "Hey",
                LastName = "Hey",
                HashPassword = "dppddppd"
            },
                new UserFilter { FirstName = "Hello", LastName = "There" });
            var actualUser = usersRepository.Get(new UserFilter { FirstName = "Hey", LastName = "Hey" });
            Assert.AreEqual(actualUser.FirstName, expectedUser.FirstName);
            Assert.AreEqual(actualUser.LastName, expectedUser.LastName);
            usersRepository.Delete(new UserFilter { Id = actualUser.Id });
        }
        [TestMethod]
        public void DeleteUserTest()
        {
            var expectedRows = usersRepository.GetAll().Count();
            usersRepository.Create(user);
            var tempUser = usersRepository.Get(new UserFilter { FirstName = "Hello", LastName = "There" });
            usersRepository.Delete(new UserFilter { Id = tempUser.Id });
            var actualRows = usersRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
