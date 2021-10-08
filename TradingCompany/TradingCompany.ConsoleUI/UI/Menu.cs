using System;
using System.Collections.Generic;
using TradingCompany.ConsoleUI.RepoMenu.Impl;

namespace TradingCompany.ConsoleUI.UI
{
    public class Menu
    {
        private List<string> MainMenuValues;
        private List<string> TablesMenuValues;
        private List<string> ActionsMenuValues;

        private UserMenu userMenu;
        private SupplierToProductMenu suppToProdtMenu;
        private RoleMenu roleMenu;
        private ProductMenu productMenu;
        private OrderToProductMenu orderToProductMenu;
        private OrderMenu orderMenu;
        private SupplierMenu supplierMenu;

        public Menu()
        {
            Initialize();
        }

        public void Initialize()
        {
            userMenu = new UserMenu();
            supplierMenu = new SupplierMenu();
            suppToProdtMenu = new SupplierToProductMenu();
            roleMenu = new RoleMenu();
            productMenu = new ProductMenu();
            orderToProductMenu = new OrderToProductMenu();
            orderMenu = new OrderMenu();

            this.ActionsMenuValues = new List<string>() { "1. Create", "2. Delete", "3. Update", "4. Show", "5. Exit" };
            this.TablesMenuValues = new List<string>() { "1. User", "2. Supplier", "3. SuppliersToProducts", "4. Roles", "5. Product", "6. OrderToProduct", "7. Order", "2. Exit" };
            this.MainMenuValues = new List<string>() { "1. Tables", "2. Exit" };
        }
        public void MainMenu()
        {
            ConsoleKey action;
            do
            {
                Console.Clear();
                PrintMainMenu();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        TablesMenu();
                        break;
                    case ConsoleKey.D2:
                        action = ConsoleKey.Escape;
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void TablesMenu()
        {
            int chosenTable = 0;
            ConsoleKey action;
            PrintMainMenu();
            do
            {
                Console.Clear();
                PrintTablesMenu();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        chosenTable = 1;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D2:
                        chosenTable = 2;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D3:
                        chosenTable = 3;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D4:
                        chosenTable = 4;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D5:
                        chosenTable = 5;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D6:
                        chosenTable = 6;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D7:
                        chosenTable = 7;
                        ActionsMenu(chosenTable);
                        break;
                    case ConsoleKey.D8:
                        chosenTable = 0;
                        action = ConsoleKey.Escape;
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void ActionsMenu(int chosenTable)
        {
            ConsoleKey action;
            PrintActions();
            do
            {
                Console.Clear();
                PrintActions();
                action = Console.ReadKey(true).Key;
                switch (action)
                {
                    case ConsoleKey.D1:
                        AddEntity(chosenTable);
                        break;
                    case ConsoleKey.D2:
                        DeleteEntity(chosenTable);
                        break;
                    case ConsoleKey.D3:
                        Update(chosenTable);
                        break;
                    case ConsoleKey.D4:
                        PrintTable(chosenTable);
                        break;
                    case ConsoleKey.D5:
                        action = ConsoleKey.Escape;
                        break;
                }
            } while (action != ConsoleKey.Escape);
        }
        private void PrintMainMenu()
        {
            foreach (string el in MainMenuValues)
            {
                Console.WriteLine(el);
            }
        }
        private void PrintTablesMenu()
        {
            foreach (string el in TablesMenuValues)
            {
                Console.WriteLine(el);
            }
        }
        private void PrintActions()
        {
            foreach (string el in ActionsMenuValues)
            {
                Console.WriteLine(el);
            }
        }
        private void PrintTable(int chosenTable)
        {
            this.TablesMenuValues = new List<string>() { "1. User", "2. Supplier", "3. SuppliersToProducts", "4. Roles", "5. Product", "6. OrderToProduct", "7. Order", "2. Exit" };

            switch (chosenTable)
            {
                case 1:
                    userMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
                case 2:
                    supplierMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
                case 3:
                    suppToProdtMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
                case 4:
                    roleMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
                case 5:
                    productMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
                case 6:
                    orderToProductMenu.OutputValues();
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
                case 7:
                    orderMenu.OutputValues();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Press 'Enter' key to continue.");
                    Console.ReadKey();
                    break;
            }
        }

        private void AddEntity(int chosenTable)
        {
            try
            {
                switch (chosenTable)
                {
                    case 1:
                        userMenu.Add();
                        break;
                    case 2:
                        supplierMenu.Add();
                        break;
                    case 3:
                        suppToProdtMenu.Add();
                        break;
                    case 4:
                        roleMenu.Add();
                        break;
                    case 5:
                        productMenu.Add();
                        break;
                    case 6:
                        orderToProductMenu.Add();
                        break;
                    case 7:
                        orderMenu.Add();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, malinformed values.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Press 'Enter' to continue");
            Console.WriteLine("done");
            Console.ReadKey();
        }
        private void DeleteEntity(int chosenTable)
        {
            Console.Write("Id: ");
            string strId = Console.ReadLine();
            ulong id;
            if (UInt64.TryParse(strId, out id))
            {
                id = UInt64.Parse(strId);
            }
            else
            {
                Console.WriteLine("Error, wrong id value.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadKey();
                return;
            }
            try
            {
                switch (chosenTable)
                {
                    case 1:
                        userMenu.Delete(id);
                        break;
                    case 2:
                        supplierMenu.Delete(id);
                        break;
                    case 3:
                        suppToProdtMenu.Delete(id);
                        break;
                    case 4:
                        roleMenu.Delete(id);
                        break;
                    case 5:
                        productMenu.Delete(id);
                        break;
                    case 6:
                        orderToProductMenu.Delete(id);
                        break;
                    case 7:
                        orderMenu.Delete(id);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, malinformed values");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Press 'Enter' to continue");
            Console.WriteLine("done");
            Console.ReadKey();
        }
        private void Update(int chosenTable)
        {
            Console.Write("Id: ");
            string strId = Console.ReadLine();
            ulong id;
            if (UInt64.TryParse(strId, out id))
            {
                id = UInt64.Parse(strId);
            }
            else
            {
                Console.WriteLine("Error, wrong id value.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadKey();
                return;
            }
            try
            {
                switch (chosenTable)
                {
                    case 1:
                        userMenu.Update(id);
                        break;
                    case 2:
                        supplierMenu.Update(id);
                        break;
                    case 3:
                        suppToProdtMenu.Update(id);
                        break;
                    case 4:
                        roleMenu.Update(id);
                        break;
                    case 5:
                        productMenu.Update(id);
                        break;
                    case 6:
                        orderToProductMenu.Update(id);
                        break;
                    case 7:
                        orderMenu.Update(id);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Malinformal values");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("done");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadKey();

        }
    }
}