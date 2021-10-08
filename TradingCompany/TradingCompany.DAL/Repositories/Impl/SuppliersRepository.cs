using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.Repositories.Impl
{
    public class SuppliersRepository : BasicRepository<Supplier, SupplierFilter>, ISuppliersRepository
    {
        internal static readonly string tableName = "tblSuppliers";

        public SuppliersRepository() : base(tableName) { }

        //CRUD
        internal override Supplier FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                Supplier entity = new Supplier();
                entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.Name = reader["Name"].ToString();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(SupplierFilter filter, string prefix = "")
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
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<string> GetFilterValues(SupplierFilter entity)
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
            return valuesList;
        }
        internal override List<string> GetEntityValues(Supplier entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
