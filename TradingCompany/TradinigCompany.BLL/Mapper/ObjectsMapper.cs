using AutoMapper;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.DAL.Models.Entities.Impl;

namespace TradingCompany.BLL.Mapper
{
    public static class ObjectsMapper
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, UserViewModel>()
                    .ForMember(x => x.Role,
                               m => m.MapFrom(y => y.Role.Name));
                cfg.CreateMap<UserViewModel, User>();

                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<OrderDTO, OrderViewModel>()
                   .ForMember(x => x.User,
                               m => m.MapFrom(y => y.User.Email));
                cfg.CreateMap<OrderViewModel, Order>();

                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, UserViewModel>()
                    .ForMember(x => x.Role,
                               m => m.MapFrom(y => y.Role.Name));
                cfg.CreateMap<UserViewModel, User>();

                cfg.CreateMap<Product, ProductDTO>();

                cfg.CreateMap<SupplierDTO, Supplier>();
                cfg.CreateMap<Supplier, SupplierDTO>();


                cfg.CreateMap<SupplierToProduct, SuppToProdDTO>();
                cfg.CreateMap<SuppToProdDTO, SuppToProdViewModel>()
                    .ForMember(x => x.Supplier,
                               m => m.MapFrom(y => y.Supplier.Name))
                    .ForMember(x => x.Product,
                               m => m.MapFrom(y => y.Product.Name));

                cfg.CreateMap<SuppToProdViewModel, SupplierToProduct>();
            }).CreateMapper();
        }
    }
}
