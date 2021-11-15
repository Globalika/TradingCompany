using TradingCompany.BLL.DTO;

namespace TradingCompany.BLL.Services.Abstract
{
    public interface IAuthenticationService
    {
        //
        bool CheckCredentials(CredentialsDTO credentials);
        bool UserExist(string email);
    }
}
