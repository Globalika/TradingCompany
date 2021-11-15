using TradingCompany.DAL.Repositories.Abstract;
using TradingCompany.DAL.Repositories.Impl;
using TradingCompany.DAL.UnitOfWork;
using Unity;
using Unity.Resolution;

namespace TradingCompany.DAL
{
    public static class DependencyInjectorDAL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();
        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();

            return container;
        }

        public static void RegisterDALTypes(this IUnityContainer container)
        {
            container
                .RegisterType<IOrdersRepository, OrdersRepository>()
                .RegisterType<IOrdersToProductsRepository, OrdersToProductsRepository>()
                .RegisterType<IProductsRepository, ProductsRepository>()
                .RegisterType<IRolesRepository, RolesRepository>()
                .RegisterType<ISuppliersRepository, SuppliersRepository>()
                .RegisterType<ISuppToProdRepository, SuppToProdRepository>()
                .RegisterType<IUsersRepository, UsersRepository>()
                .RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}
