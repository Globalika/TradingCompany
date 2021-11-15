using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly TradingCompanyContext _context;

        private IOrdersRepository _ordersRepository;

        private IOrdersToProductsRepository _ordersToProductsRepository;

        private IProductsRepository _productsRepository;

        private IRolesRepository _rolesRepository;

        private ISuppliersRepository _suppliersRepository;

        private ISuppToProdRepository _suppToProdRepository;

        private IUsersRepository _usersRepository;

        public UnitOfWork() //TradingCompanyContext context
        {
            //_context = context;
        }

        public IOrdersRepository OrdersRepository
        {
            get
            {
                if (_ordersRepository == null)
                {
                    _ordersRepository = DependencyInjectorDAL.
                        Resolve<IOrdersRepository>();
                }

                return _ordersRepository;
            }
        }
        public IOrdersToProductsRepository OrdersToProductsRepository
        {
            get
            {
                if (_ordersToProductsRepository == null)
                {
                    _ordersToProductsRepository = DependencyInjectorDAL.
                        Resolve<IOrdersToProductsRepository>();
                }

                return _ordersToProductsRepository;
            }
        }
        public IProductsRepository ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _productsRepository = DependencyInjectorDAL.
                        Resolve<IProductsRepository>();
                }

                return _productsRepository;
            }
        }
        public IRolesRepository RolesRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _rolesRepository = DependencyInjectorDAL.
                        Resolve<IRolesRepository>();
                }

                return _rolesRepository;
            }
        }
        public ISuppliersRepository SuppliersRepository
        {
            get
            {
                if (_suppliersRepository == null)
                {
                    _suppliersRepository = DependencyInjectorDAL.
                        Resolve<ISuppliersRepository>();
                }

                return _suppliersRepository;
            }
        }
        public ISuppToProdRepository SuppToProdRepository
        {
            get
            {
                if (_suppToProdRepository == null)
                {
                    _suppToProdRepository = DependencyInjectorDAL.
                        Resolve<ISuppToProdRepository>();
                }

                return _suppToProdRepository;
            }
        }
        public IUsersRepository UsersRepository
        {
            get
            {
                if (_usersRepository == null)
                {
                    _usersRepository = DependencyInjectorDAL.
                        Resolve<IUsersRepository>();
                }

                return _usersRepository;
            }
        }
    }
}
