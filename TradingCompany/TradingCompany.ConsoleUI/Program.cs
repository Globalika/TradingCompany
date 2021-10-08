using TradingCompany.ConsoleUI.UI;
using TradingCompany.DAL.Database;

namespace TradingCompany.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MigrationManager migrationManager = new MigrationManager();
            migrationManager.DropTables();
            migrationManager.CreateTables();
            migrationManager.ImportStartValues();

            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
