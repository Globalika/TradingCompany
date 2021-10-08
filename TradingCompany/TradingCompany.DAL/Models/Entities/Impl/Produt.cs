using TradingCompany.DAL.Models.Entities.Abstract;

namespace TradingCompany.DAL.Models.Entities.Impl
{
    public class Product : IBaseEntity
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string ProducingCountry { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} \nName: {1} \nBrand: {2} \nProducingCOuntry: {3} \nPrice: {4} \n",
                Id, Name, Brand, ProducingCountry, Price);
        }
    }
}