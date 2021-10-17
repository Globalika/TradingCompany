using System.IO;
using TradingCompany.DAL.Core;

namespace TradingCompany.DAL.Database
{
    public class MigrationManager
    {
        DbManager dbManager = new DbManager();

        public bool CreateTables()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\TradingCompany.DAL\Database\create_tables.sql");
            string script = File.ReadAllText(path);
            dbManager.ExecuteNonQuery(script);
            return true;
        }
        public bool DropTables()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\TradingCompany.DAL\Database\drop_tables.sql");

            string script = File.ReadAllText(path);
            dbManager.ExecuteNonQuery(script);
            return true;
        }

        public bool ImportStartValues()
        {
            string path = System.IO.Path.GetFullPath(@"..\..\..\TradingCompany.DAL\Database\import_start_values.sql");
            string script = File.ReadAllText(path);
            dbManager.ExecuteNonQuery(script);
            return true;
        }
    }
}
