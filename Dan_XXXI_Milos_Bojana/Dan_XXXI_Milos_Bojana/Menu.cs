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
            bool ok = true;

            Console.WriteLine("* * * Welcome dear guest :) * * *");
            Console.WriteLine("[1] Make a reservation");
            Console.WriteLine("[2] Update a reservation");
            Console.WriteLine("[3] View all reservations");
            Console.WriteLine("[4] Cancel reservation");
            Console.WriteLine("[5] Exit\n");


            do
            {
                Console.Write("Select an option from 1 to 5 -> ");
                choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice))
                {

                    ok = false;
                }
                else if (choice.Equals("*"))
                {
                    break;
                }
                else if (!choice.Equals("1") && !choice.Equals("2") && !choice.Equals("3") && !choice.Equals("4"))
                {
                    //ConsoleMessages.ErrorInput();
                    ok = false;
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            //tableReservation.MakeReservation();
                            break;
                        case "2":
                            Console.WriteLine("\nDear guest this option will be available soon. Thanks for your patience.");
                            break;
                        case "3":
                            //tableReservation.ViewReservation();
                            break;
                        case "4":
                            //tableReservation.CancelReservation();
                            break;
                    }
                }
            } while (!ok);
        }
    }
}
