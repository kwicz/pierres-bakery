using System;
using System.Collections.Generic;

namespace Bakery.Models
{
	public class NewOrder
	{
		public static double orderCost = 0;
		public static List<string> orderItems = new List<string> {};

		public static void Order()
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"(っ◔◡◔)っ ♥ What would you like to order today? ♥"); 
			Console.ForegroundColor = ConsoleColor.White;
			string userOrder = Console.ReadLine();
			userOrder = userOrder.ToLower();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			if (Menu.menuItems.ContainsKey(userOrder))
			{
				AddToOrder(userOrder);
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
            orderCost += Menu.menuItems[food];
            break;
        }
      }
    }

		public static void OrderMore()
		{
			// Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"(っ◔◡◔)っ ♥ Is there anything else I can get for you? ♥");
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
|  " + item + "                  $" + Menu.menuItems[item] + ".00 |");
      }
      Console.WriteLine(@"
|                 Total: $" + orderCost + ".00 |");
    }
	}
}