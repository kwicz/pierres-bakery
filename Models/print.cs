using System;
using System.Collections.Generic;

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
			Console.WriteLine(@"(っ◔◡◔)っ ♥ Today's Specials are: ♥");
			Console.WriteLine(@"🍞 Buy 2 loaves of bread, Get 1 free! 🍞");
			Console.WriteLine(@"🥐  Buy 2 pastries, Get 1 half off! 🥐");
			Console.WriteLine("___________________________________________");
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
             |  🥐 Pastry                 $2.00  |
             |    *3 for $5!                    |
             |                                  |
             |        ______Food______          |
             |  🥯 Bagel                  $2.00  |
             |  🍩 Donut                  $1.00  |
             |  🍰 Cake                   $4.00  |
             |       ______Drinks______         |
             |  🥛 Milk                   $1.00  |
             |  ☕️ Coffee                 $2.00  |
             |  🍷 Wine                   $6.00  |
             |____    _______    __  ____    ___|
            /A\                                  \
           ((o))                                  )
            '-'----------------------------------'			
			");
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine((@"(っ◔◡◔)っ ♥ Press [O] to order! ♥"));
			Console.ForegroundColor = ConsoleColor.White;
			string order = Console.ReadLine();
			order = order.ToLower();
			if (order == "o")
			{
				Store.Order();
			}
			else
			{
				Menu();
			}
		}

	}
}