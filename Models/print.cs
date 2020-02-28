using System;

namespace Bakery.Models
{
	public class Printer
	{
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
			Console.WriteLine(@"(っ◔◡◔)っ ♥ Today's Specials are: ♥")
			Console.WriteLine(@"🍞Buy 2 loaves of bread, Get 1 free! 🍞");
			Console.WriteLine(@"🥐 Buy 2 pastries, Get 1 half off! 🥐");

		}

		public static void UserMenu()
		{
			Console.WriteLine(@"(っ◔◡◔)っ ♥ How can we help you today? ♥");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("(Select a number) \n[1] Order \n[2] See the menu. \n[3] Learn some useful French phrases.");
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
			Console.WriteLine("What would you like to order? Tell us your order or press [M] to see the Menu.");
			string userOrder = Console.ReadLine();
			userOrder = userOrder.ToLower();
			double orderTotal = 0.00;
			switch(userOrder)
			{
				case "bread":
				{
					Console.WriteLine("How many loaves would you like?");
					string amountString = Console.ReadLine();
					int amount = int.Parse(amountString);
					orderTotal += Bread.OrderBread(amount);
				}
				case "pastry" || "pastries":
				{
					Console.WriteLine("How many pastries would you like?");
					string amountString = Console.ReadLine();
					int amount = int.Parse(amountString);
					orderTotal += Pastry.OrderPastry(amount);
				}
				case "m":
				{
					Menu();	
				}
				default:
				{
					Console.WriteLine("I'm sorry, but I didn't understand that.");
					Order();
				}
			}
			Console.WriteLine("The total cost of your order is " + orderTotal + ".");
			OrderMore();
		}

		public static void OrderMore()
		{
			Console.WriteLine("Would you like to order more? [Y]es or [N]o");
			string orderMore = Console.ReadLine();
			orderMore = orderMore.ToLower();
			switch(orderMore)
			{
				case "y":
				{
					Order();
				}
				case "n":
				{
					Console.WriteLine("Thank you for coming to Pierre's Bakery!");
				}
				default:
				{
					Console.WriteLine("I'm sorry, but I didn't understand that.");
					OrderMore();
				}
			}
		}

		public static void Menu()
		{
			Console.WriteLine("Menu");
		}

	}
}