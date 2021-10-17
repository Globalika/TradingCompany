using TradingCompany.DAL.Models.Entities.Impl;
using TradingCompany.DAL.Models.Filters.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using TradingCompany.DAL.Repositories.Abstract;

namespace TradingCompany.DAL.Repositories.Impl
{
    public class UsersRepository : BasicRepository<User, UserFilter>, IUsersRepository
    {
        internal static readonly string tableName = "tblUsers";

        public UsersRepository() : base(tableName) { }

        //CRUD
        internal override User FillEntity(DbDataReader reader)
        {
            if (reader.HasRows == false)
            {
                return null;
            }
            try
            {
                User entity = new User();
                entity.Id = Convert.ToUInt64(reader["Id"]);
                entity.FirstName = reader["FirstName"].ToString();
                entity.LastName = reader["LastName"].ToString();
                entity.Email = reader["Email"].ToString();
                entity.HashPassword = reader["HashPassword"].ToString();
                entity.RoleId = Convert.ToUInt64(reader["RoleId"]);
                entity.RowInsertTime = Convert.ToDateTime(reader["RowInsertTime"].ToString());
                entity.RowUpdateTime = Convert.ToDateTime(reader["RowUpdateTime"].ToString());

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal override List<DbParameter> GetParameters(UserFilter filter, string prefix = "")
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
                if (filter.FirstName != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "FirstName", 50, filter.FirstName, DbType.String));
                }
                if (filter.LastName != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "LastName", 50, filter.LastName, DbType.String));
                }
                if (filter.Email != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "Email", 50, filter.Email, DbType.String));
                }
                if (filter.HashPassword != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "HashPassword", 256, filter.HashPassword, DbType.String));
                }
                if (filter.RoleId != null)
                {
                    parameters.Add(dbManager.CreateParameter(prefix + "RoleId", 50, filter.RoleId, DbType.String));
                }
                return parameters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal override List<DbParameter> GetParameters(User entity, string prefix = "")
        {
            return GetParameters(EntityToFilter(entity), prefix);
        }
        internal override List<string> GetFilterValues(UserFilter entity)
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
            if (entity.FirstName != null)
            {
                valuesList.Add("FirstName");
            }
            if (entity.LastName != null)
            {
                valuesList.Add("LastName");
            }
            if (entity.Email != null)
            {
                valuesList.Add("Email");
            }
            if (entity.HashPassword != null)
            {
                valuesList.Add("HashPassword");
            }
            if (entity.RoleId != null)
            {
                valuesList.Add("RoleId");
            }
            return valuesList;
        }
        internal override List<string> GetEntityValues(User entity)
        {
            return GetFilterValues(EntityToFilter(entity));
        }
    }
}
