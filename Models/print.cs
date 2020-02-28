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
		}

		public static void UserMenu()
		{
			Console.WriteLine(@"(っ◔◡◔)っ ♥ How can we help you today? ♥");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("(Select a number) \n[1] See the menu. \n[2] Speak to the manager. \n[3] Practice your French.");
			string menuSelection = Console.ReadLine();
			switch (menuSelection)
			{
				case "1":
					Console.WriteLine("Here's our menu!");
					break;
				case "2":
					Console.WriteLine("Here's our manager!");
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