using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.Repositories.Impl
{
    public class SuppToProdRepository : BasicRepository<SupplierToProduct, SupplierToProductFilter>, ISuppToProdRepository
    {
        internal static readonly string tableName = "tblSuppliersToProducts";

        public SuppToProdRepository() : base(tableName) { }

        //CRUD
        internal override SupplierToProduct FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                SupplierToProduct entity = new SupplierToProduct();
                entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.ProductId = Convert.ToUInt64(reader["ProductId"]);
                entity.SupplierId = Convert.ToUInt64(reader["SupplierId"]);
                entity.RowInsertTime = Convert.ToDateTime(reader["RowInsertTime"].ToString());
                entity.RowUpdateTime = Convert.ToDateTime(reader["RowUpdateTime"].ToString());
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(SupplierToProductFilter filter, string prefix = "")
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
                if (filter.SupplierId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "SupplierId", filter.SupplierId, DbType.Int64));
                }
                if (filter.ProductId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "ProductId", filter.ProductId, DbType.Int64));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParameters(SupplierToProduct entity, string prefix = "")
        {
            return GetParameters(EntityToFilter(entity), prefix);
        }
        internal override List<string> GetFilterValues(SupplierToProductFilter entity)
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
            if (entity.ProductId != null)
            {
                valuesList.Add("ProductId");
            }
            if (entity.SupplierId != null)
            {
                valuesList.Add("SupplierId");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(SupplierToProduct entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
