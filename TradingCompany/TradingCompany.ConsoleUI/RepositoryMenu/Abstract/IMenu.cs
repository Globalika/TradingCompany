using System.Collections.Generic;

namespace TradingCompany.ConsoleUI.Abstract.RepoMenu
{
    public interface IMenu<TRepository, TEnity>
    {
        void Add();
        void Delete(ulong id);
        void Update(ulong id);
        IEnumerable<TEnity> GetAll();
        void OutputValues();
    }
}
