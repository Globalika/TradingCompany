using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Security;
using TradingCompany.BLL.Services.Impl;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLLUnitTests
{
    [TestClass]
    public class AuthenticationServiceUnitTests
    {
        [TestMethod]
        public void PasswordHashTest()
        {
            string password = "password";
            string hashPassword = PasswordHandler.Hash(password);
            Assert.IsTrue(PasswordHandler.Verify(password, hashPassword));
        }
        [TestMethod]
        public void UserExistTest()//CheckCredentials
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            AuthenticationService service = new AuthenticationService(unitOfWork);
            Assert.IsTrue(service.UserExist("admin"));
        }
        [TestMethod]
        public void CheckCredentialsTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            AuthenticationService service = new AuthenticationService(unitOfWork);
            CredentialsDTO credentials = new CredentialsDTO()
            {
                Login = "admin",
                Password = "12345678"
            };
            Assert.IsTrue(service.CheckCredentials(credentials));
        }
    }
}
