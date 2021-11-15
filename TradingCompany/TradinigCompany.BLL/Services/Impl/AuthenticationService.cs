using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Security;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Impl
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool CheckCredentials(CredentialsDTO credentials)
        {

            User user = _unitOfWork.UsersRepository.Get(new UserFilter() { Email = credentials.Login });
            if (PasswordHandler.Verify(credentials.Password, user.HashPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserExist(string email)
        {
            if (_unitOfWork.UsersRepository.Get(new UserFilter() { Email = email }) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
