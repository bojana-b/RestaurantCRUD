using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XXXI_Milos_Bojana
{
    class Menu
    {
        public static void StartMenu()
        {
            string choice;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("* * * Welcome dear guest :) * * *");
                Console.WriteLine("[1] Make order");
                Console.WriteLine("[2] Update order");
                Console.WriteLine("[3] View all orders");
                Console.WriteLine("[4] Cancel order");
                Console.WriteLine("[5] Exit\n");
                Console.Write("Select an option from 1 to 5 -> ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Please Choose item from menu. (Enter any string!)");
                        string item = Console.ReadLine();
                        Restaurant restaurant = new Restaurant(item, DateTime.Now);
                        Utility.Create(restaurant);
                        Console.WriteLine("Item added successfully");
                        break;
                    case "2":
                        Console.WriteLine("Please select order you want to update");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Choose item from menu");
                        string item1 = Console.ReadLine();
                        Restaurant restaurant1 = new Restaurant(item1, DateTime.Now);
                        Utility.Update(id, restaurant1);
                        Console.WriteLine("Item updated successfully");
                        break;
                    case "3":
                        List<tblOrder> restaurants = Utility.Load();
                        Console.WriteLine("Listing current orders: ");
                        foreach (var rst in restaurants)
                        {
                            Console.WriteLine("Order ID: " + rst.OrderID + " Date: " + rst.Date + " Item ordered: " + rst.MenuItem);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Please select order you want to update");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        Utility.Delete(idToDelete);
                        Console.WriteLine("Item deleted successfully");
                        break;
                    case "5":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } 
        }
    }
}
