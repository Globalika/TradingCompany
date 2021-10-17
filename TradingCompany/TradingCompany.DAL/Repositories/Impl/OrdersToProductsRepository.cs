using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.Repositories.Impl
{
    public class OrdersToProductsRepository : BasicRepository<OrderToProduct, OrderToProductFilter>, IOrdersToProductsRepository
    {
        internal static readonly string tableName = "tblOrdersToProducts";

        public OrdersToProductsRepository() : base(tableName) { }

        //CRUD
        internal override OrderToProduct FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                OrderToProduct entity = new OrderToProduct();
                entity.ProductId = Convert.ToUInt64(reader["ProductId"]);
                entity.OrderId = Convert.ToUInt64(reader["OrderId"]);
                entity.Quantity = Convert.ToInt32(reader["Quantity"]);
                entity.RowInsertTime = Convert.ToDateTime(reader["RowInsertTime"].ToString());
                entity.RowUpdateTime = Convert.ToDateTime(reader["RowUpdateTime"].ToString());

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(OrderToProductFilter filter, string prefix = "")
        {
            if (filter == null)
            {
                return new List<DbParameter>();
            }
            try
            {
                prefix = "@" + prefix;
                List<DbParameter> parameters = new List<DbParameter>();
                if (filter.ProductId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "ProductId", 50, filter.ProductId, DbType.Int64));
                }
                if (filter.OrderId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "OrderId", 50, filter.OrderId, DbType.Int64));
                }
                if (filter.Quantity != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Quantity", 50, filter.Quantity, DbType.Int32));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParameters(OrderToProduct entity, string prefix = "")
        {
            return GetParameters(EntityToFilter(entity), prefix);
        }
        internal override List<string> GetFilterValues(OrderToProductFilter entity)
        {
            if (entity == null)
            {
                return new List<string>();
            }
            List<string> valuesList = new List<string>();

            if (entity.ProductId != null)
            {
                valuesList.Add("ProductId");
            }
            if (entity.OrderId != null)
            {
                valuesList.Add("OrderId");
            }
            if (entity.Quantity != null)
            {
                valuesList.Add("Quantity");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(OrderToProduct entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
