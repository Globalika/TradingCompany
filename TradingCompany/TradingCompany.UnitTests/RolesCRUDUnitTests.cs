using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.Repositories.Impl;

namespace TradingCompany.UnitTests
{
    [TestClass]
    public class RolesCRUDUnitTests
    {
        RolesRepository rolesRepository = new RolesRepository();
        private Role role = new Role
        {
            Name = "Admiral"
        };
        [TestMethod]
        public void CreateRoleTest()
        {
            var expectedRole = role;
            rolesRepository.Create(expectedRole);
            var actualRole = rolesRepository.Get(new RoleFilter { Name = "Admiral" });
            Assert.AreEqual(actualRole.Name, expectedRole.Name);
            rolesRepository.Delete(new RoleFilter { Id = actualRole.Id });
        }
        [TestMethod]
        public void UpdateRoleTest()
        {
            var expectedRole = new Role
            {
                Name = "General"
            };
            rolesRepository.Create(role);
            rolesRepository.Update(new Role
            {
                Name = "General"
            },
                new RoleFilter { Name = "Admiral" });
            var actualRole = rolesRepository.Get(new RoleFilter { Name = "General" } );
            Assert.AreEqual(actualRole.Name, expectedRole.Name);
            rolesRepository.Delete(new RoleFilter { Id = actualRole.Id });
        }
        [TestMethod]
        public void DeleteRoleTest()
        {
            var expectedRows = rolesRepository.GetAll().Count();
            rolesRepository.Create(role);
            var tempUser = rolesRepository.Get(new RoleFilter { Name = "Admiral" });
            rolesRepository.Delete(new RoleFilter { Id = tempUser.Id });
            var actualRows = rolesRepository.GetAll().Count();
            Assert.AreEqual(expectedRows, actualRows);
        }
    }
}
