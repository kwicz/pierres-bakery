using System;
using System.Collections.Generic;

namespace Bakery.Models
{
	public class Printer
	{
		public static double orderCost = 0;
		public static List<string> orderItems = new List<string> {};
		public static void Welcome()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"𝓦𝓮𝓵𝓬𝓸𝓶𝓮 𝓽𝓸");
			Console.WriteLine(@"                                                    
-__ /\\                              )            _-_ _,,         ,,                      
  ||  \\  '                                          -/  )    _   ||                      
 /||__|| \\  _-_  ,._-_ ,._-_  _-_     _-_,         ~||_<    < \, ||/\  _-_  ,._-_ '\\/\\ 
 \||__|| || || \\  ||    ||   || \\   ||_.           || \\   /-|| ||_< || \\  ||    || ;' 
  ||  |, || ||/    ||    ||   ||/      ~ ||          ,/--|| (( || || | ||/    ||    ||/   
_-||-_/  \\ \\,/   \\,   \\,  \\,/    ,-_-          _--_-'   \/\\ \\,\ \\,/   \\,   |/    
  ||                                               (                               (      
                                                                                    -_-        
			");
			Console.WriteLine(@"(っ◔◡◔)っ ♥ Today's Specials are: ♥");
			Console.WriteLine(@"🍞 Buy 2 loaves of bread, Get 1 free! 🍞");
			Console.WriteLine(@"🥐  Buy 2 pastries, Get 1 half off! 🥐");
			Console.WriteLine("___________________________________________");

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
					Menu();
					break;
				case "3":
					Console.WriteLine("What would you like to say?");
					break;
				default:
					Console.WriteLine("Sorry, we didn't understand that.");
					UserMenu();
					break;
			}
		}

		public static void Order()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("What would you like to order?"); 
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Enter item name\n[M] to see the Menu.");
			string userOrder = Console.ReadLine();
			userOrder = userOrder.ToLower();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			if (userOrder == "bread")
			{
				Bread bread = new Bread();
				Console.WriteLine("How many loaves of bread would you like?");
				Console.ForegroundColor = ConsoleColor.White;
				string amountString = Console.ReadLine();
				int amount = int.Parse(amountString);
				for (int i = 0; i < amount; i ++)
				{
					orderItems.Add("loaf of bread");
				}
				orderCost += bread.OrderBread(amount);
			}
			else if (userOrder == "pastry" || userOrder == "pastries")
			{
				Pastry pastry = new Pastry();
				Console.WriteLine("How many pastries would you like?");
				Console.ForegroundColor = ConsoleColor.White;
				string amountString = Console.ReadLine();
				int amount = int.Parse(amountString);
				for (int i = 0; i < amount; i ++)
				{
					orderItems.Add("pastry");
				}
				orderCost += pastry.OrderPastries(amount);
			}
			else if (userOrder == "m")
			{
				Menu();
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

		public static void OrderMore()
		{
			Console.Clear();
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

		public static void Menu()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine(@"
           .-.---------------------------------.-.
          ((o))                                   )
           \U/_______          _____         ____/
             |                                  |
             |        𝓟𝓲𝓮𝓻𝓻𝓮'𝓼 𝓑𝓪𝓴𝓮𝓻𝔂           |
             |   ______Today's Specials______   |
             |  🍞 Bread                  $5.00  |
             |    *Buy 2, Get 1 Free!           |
             |  🥐 Pastries               $2.00  |
             |    *3 for $5!                    |
             |                                  |
             |        ______Menu______          |
             |  🥯 Bagels                 $2.00  |
             |  🍩 Donuts                 $1.00  |
             |  🍰 Slice of Cake          $4.00  |
             |  🥧 Pie                   $12.00  |
             |                                  |
             |  🥛 Milk                   $1.00  |
             |  ☕️ Coffee                 $2.00  |
             |  🍷 Wine                   $6.00  |
             |____    _______    __  ____    ___|
            /A\                                  \
           ((o))                                  )
            '-'----------------------------------'			
			");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Press [O] to Order");
			string order = Console.ReadLine();
			order = order.ToLower();
			if (order == "o")
			{
				Order();
			}
			else
			{
				Menu();
			}
		}

	}
}