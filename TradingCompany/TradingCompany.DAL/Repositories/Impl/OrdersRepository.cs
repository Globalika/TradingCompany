using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.Repositories.Impl
{
    public class OrdersRepository : BasicRepository<Order, OrderFilter>, IOrdersRepository
    {
        internal static readonly string tableName = "tblOrders";

        public OrdersRepository() : base(tableName) { }

        //CRUD
        internal override Order FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                Order entity = new Order();
                entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.UserId = Convert.ToUInt64(reader["UserId"]);
                entity.Destination = reader["Destination"].ToString();
                entity.OrderDate = Convert.ToDateTime(reader["OrderDate"].ToString());
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(OrderFilter filter, string prefix = "")
        {
            if (filter == null)
            {
                return new List<DbParameter>();
            }
            try
            {
                prefix = "@" + prefix;
                List<DbParameter> parameters = new List<DbParameter>();
                if (filter.Id != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Id", filter.Id, DbType.Int64));
                }
                if (filter.UserId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "UserId", 50, filter.UserId, DbType.Int64));
                }
                if (filter.Destination != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Destination", 50, filter.Destination, DbType.String));
                }
                if (filter.OrderDate != null && filter.OrderDate.ToString() != "1/1/0001 12:00:00 AM" && filter.OrderDate.ToString() != "01.01.0001 0:00:00")
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "OrderDate", 50, filter.OrderDate, DbType.Date));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParameters(Order entity, string prefix = "")
        {
            return GetParameters(EntityToFilter(entity), prefix);
        }
        internal override List<string> GetFilterValues(OrderFilter entity)
        {
            if (entity == null)
            {
                return new List<string>();
            }
            List<string> valuesList = new List<string>();

            if (entity.Id != null)
            {
                valuesList.Add("Id");
            }
            if (entity.UserId != null)
            {
                valuesList.Add("UserId");
            }
            if (entity.Destination != null)
            {
                valuesList.Add("Destination");
            }
            if (entity.OrderDate != null && entity.OrderDate.ToString() != "1/1/0001 12:00:00 AM")
            {
                valuesList.Add("OrderDate");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(Order entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
