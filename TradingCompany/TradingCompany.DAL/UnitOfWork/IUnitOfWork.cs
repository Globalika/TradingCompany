using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrdersRepository OrdersRepository { get; }
        IOrdersToProductsRepository OrdersToProductsRepository { get; }
        IProductsRepository ProductsRepository { get; }
        IRolesRepository RolesRepository { get; }
        ISuppliersRepository SuppliersRepository { get; }
        ISuppToProdRepository SuppToProdRepository { get; }
        IUsersRepository UsersRepository { get; }
    }
}
