using TradingCompany.DAL.Models.Filters.Abstract;

namespace TradingCompany.DAL.Models.Filters.Impl
{
    public class RoleFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("Id: {0} \nName: {1} \n",
                Id, Name);
        }
    }
}
