using System;
using System.Collections.Generic;
using TradingCompany.ConsoleUI.Abstract.RepoMenu;
using TradingCompany.DAL.Models.Entities.Abstract;
using TradingCompany.DAL.Models.Filters.Abstract;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.ConsoleUI.RepoMenu
{
    public abstract class BaseMenu<TRepository, TEntity, TFilter> : IMenu<TRepository, TEntity>
        where TEntity : IBaseEntity, new()
        where TFilter : IFilterable, new()
        where TRepository : IBaseRepository<TEntity, TFilter>, new()
    {
        TRepository repository;
        public BaseMenu()
        {
            repository = new TRepository();
        }
        public void Add()
        {
            TEntity entity = InputValues();
            repository.Create(entity);
        }
        public void Delete(ulong id)
        {
            repository.Delete(new TFilter() { Id = id });
        }
        public void Update(ulong id)
        {
            TEntity entity = InputValues();
            repository.Update(entity, new TFilter() { Id = id });
        }
        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }
        public virtual void OutputValues()
        {
            foreach (var entity in GetAll())
            {
                Console.WriteLine(entity);
            }
        }
        protected virtual TEntity InputValues()
        {
            return new TEntity();
        }
    }
}
