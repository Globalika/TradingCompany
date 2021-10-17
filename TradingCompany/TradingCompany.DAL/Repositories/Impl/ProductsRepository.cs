using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.Repositories.Impl
{
    public class ProductsRepository : BasicRepository<Product, ProductFilter>, IProductsRepository
    {
        internal static readonly string tableName = "tblProducts";

        public ProductsRepository() : base(tableName) { }

        //CRUD
        internal override Product FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                Product entity = new Product();
                entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.Name = reader["Name"].ToString();
                entity.Brand = reader["Brand"].ToString();
                entity.ProducingCountry = reader["ProducingCountry"].ToString();
                entity.Price = Convert.ToInt32(reader["Price"]);
                entity.RowInsertTime = Convert.ToDateTime(reader["RowInsertTime"].ToString());
                entity.RowUpdateTime = Convert.ToDateTime(reader["RowUpdateTime"].ToString());

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(ProductFilter filter, string prefix = "")
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
                if (filter.Name != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Name", 50, filter.Name, DbType.String));
                }
                if (filter.Brand != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Brand", 50, filter.Brand, DbType.String));
                }
                if (filter.ProducingCountry != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "ProducingCountry", 50, filter.ProducingCountry, DbType.String));
                }
                if (filter.Price != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Price", 50, filter.Price, DbType.Int32));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParameters(Product entity, string prefix = "")
        {
            return GetParameters(EntityToFilter(entity), prefix);
        }
        internal override List<string> GetFilterValues(ProductFilter entity)
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
            if (entity.Name != null)
            {
                valuesList.Add("Name");
            }
            if (entity.Brand != null)
            {
                valuesList.Add("Brand");
            }
            if (entity.ProducingCountry != null)
            {
                valuesList.Add("ProducingCountry");
            }
            if (entity.Price != null)
            {
                valuesList.Add("Price");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(Product entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
