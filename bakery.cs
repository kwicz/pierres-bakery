using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Store
  {
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
					Console.WriteLine("What would you like to say?");
					break;
				default:
					Console.WriteLine("Sorry, we didn't understand that.");
					UserMenu();
					break;
			}
		}






  }
}