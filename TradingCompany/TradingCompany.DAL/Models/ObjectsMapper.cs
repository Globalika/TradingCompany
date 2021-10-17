using AutoMapper;
using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;

namespace TradingCompany.DAL.Models
{
    public sealed class ObjectsMapper
    {
        private volatile static IMapper mapper = null;
        private static MapperConfiguration config = null;
        public static IMapper Get()
        {
            if (mapper == null)
            {
                if (config == null)
                {
                    return ConfigMapper().CreateMapper();
                }
            }
            return config.CreateMapper();
        }
        private static MapperConfiguration ConfigMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserFilter>();
                cfg.CreateMap<Supplier, SupplierFilter>();
                cfg.CreateMap<SupplierToProduct, SupplierToProductFilter>();
                cfg.CreateMap<Role, RoleFilter>();
                cfg.CreateMap<Product, ProductFilter>();
                cfg.CreateMap<OrderToProduct, OrderToProductFilter>();
                cfg.CreateMap<Order, OrderFilter>();
            });
            return config;
        }
    }
}
