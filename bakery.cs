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
      System.Threading.Thread.Sleep(5000);
      Printer.Menu();
    }

    public static void Order()
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"(っ◔◡◔)っ ♥ What would you like to order today? ♥"); 
			Console.ForegroundColor = ConsoleColor.White;
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
        Console.WriteLine(@"(っ◔◡◔)っ ♥ I'm sorry, but I didn't understand that. ♥");
        Order();
      }
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"(っ◔◡◔)っ ♥ That brings your total to $" + orderCost + ". ♥");
			OrderMore();
		}

    public static void AddToOrder(string food)
    {
      Console.WriteLine(@"(っ◔◡◔)っ ♥ How many " + food + "s would you like? ♥");
      Console.ForegroundColor = ConsoleColor.White;
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
			Console.WriteLine(@"(っ◔◡◔)っ ♥ Would you like to order more? ♥");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[Y]es \n[N]o");
			string orderMore = Console.ReadLine();
			orderMore = orderMore.ToLower();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			switch(orderMore)
			{
				case "y":
				{
          Printer.Menu();
					break;
				}
				case "n":
				{
					Printer.Reciept();
					break;
				}
				default:
				{
					Console.WriteLine(@"(っ◔◡◔)っ ♥ I'm sorry, but I didn't understand that. ♥");
					OrderMore();
					break;
				}
			}
		}

    public static void RecieptItems()
    {
      foreach (string item in orderItems)
      {
        Console.WriteLine(@"
|  " + item + "                      $" + menuItems[item] + ".00 |");
      }
      Console.WriteLine(@"
|                     Total: $" + orderCost + ".00 |");
    }


  }
}