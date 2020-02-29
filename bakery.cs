using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Store
  {
    public static double orderCost = 0;
		public static List<string> orderItems = new List<string> {};
		public static Dictionary<string, double> menuItems = new Dictionary<string, double>(6){
			{"bagel", 2.00},
			{"donut", 1.00},
			{"cake", 4.00},
			{"milk", 1.00},
			{"coffee", 2.00},
			{"wine", 6.00},
      {"bread", 5.00},
      {"pastry", 2.00}
		};
    public static void Main()
    {
      Printer.Welcome();
      UserMenu();
    }

		public static void UserMenu()
		{
			Console.WriteLine("");
			Console.WriteLine(@"(っ◔◡◔)っ ♥ How can we help you today? ♥");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[1] Order \n[2] See the menu. \n[3] Learn some useful French phrases.");
			string menuSelection = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			switch(menuSelection)
			{
				case "1":
					Order();
					break;
				case "2":
					Printer.Menu();
					break;
				case "3":
					Console.WriteLine("What would you like to learn?");
					break;
				default:
					Console.WriteLine("Sorry, we didn't understand that.");
					UserMenu();
					break;
			}
		}

    public static void Order()
		{
			// Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("What would you like to order?"); 
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[Enter Item]\n[M] to see the Menu.");
			string userOrder = Console.ReadLine();
			userOrder = userOrder.ToLower();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
      if (menuItems.ContainsKey(userOrder))
      {
        AddToOrder(userOrder);
      }
			else if (userOrder == "m")
			{
				Printer.Menu();
			}
      else
      {
        Console.WriteLine("I'm sorry, but I didn't understand that.");
        Order();
      }
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("The total cost of your order is $" + orderCost + ".");
			OrderMore();
		}

    public static void AddToOrder(string food)
    {
      Console.WriteLine("How many " + food + "s would you like?");
      string amountString = Console.ReadLine();
      int amount = int.Parse(amountString);
      for (int i = 0; i < amount; i++)
      {
        orderItems.Add(food);
        switch(food)
        {
          case "bread":
            Bread bread = new Bread();
            orderCost += bread.OrderBread(amount);
            break;
          case "pastry":
            Pastry pastry = new Pastry();
            orderCost += pastry.OrderPastries(amount);
            break;
          default:
            orderCost += menuItems[food];
            break;
        }
      }
    }

		public static void OrderMore()
		{
			// Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("Would you like to order more?");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[Y]es \n[N]o");
			string orderMore = Console.ReadLine();
			orderMore = orderMore.ToLower();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			switch(orderMore)
			{
				case "y":
				{
					Order();
					break;
				}
				case "n":
				{
					Console.WriteLine("Thank you for coming to Pierre's Bakery!");
					break;
				}
				default:
				{
					Console.WriteLine("I'm sorry, but I didn't understand that.");
					OrderMore();
					break;
				}
			}
		}








  }
}