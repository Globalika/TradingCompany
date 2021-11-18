using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.FormsUI.Login;
using TradingCompany.BLL;
using TradingCompany.BLL.Services.Abstract;
using TradingCompany.DAL.Database;

namespace TradingCompany.FormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MigrationManager migration = new MigrationManager();
            migration.DropTables();
            migration.CreateTables();
            migration.ImportStartValues();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(DependencyInjectorBLL.Resolve<LoginForm>());
        }
    }
}
