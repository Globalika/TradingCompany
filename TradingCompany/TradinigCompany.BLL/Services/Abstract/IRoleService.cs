using System.Collections.Generic;

namespace TradingCompany.BLL.Services.Abstract
{
    public interface IRoleService
    {
        IEnumerable<string> GetRoleNames();
    }
}
