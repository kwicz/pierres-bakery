using System;

namespace Bakery.Models
{
	public class Printer
	{
		public static void Welcome()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"(っ◔◡◔)っ ♥ 𝓦𝓮𝓵𝓬𝓸𝓶𝓮 𝓽𝓸 ♥");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
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
			Console.WriteLine("___________________________________________________________________________________");
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
			NewOrder.Order();
		}

		public static void Reciept()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(@"(っ◔◡◔)っ ♥ Here's your reciept! Thank you for coming to Pierre's Bakery! ♥");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine(@".------------------------------.");
			Console.WriteLine(@"|        𝓟𝓲𝓮𝓻𝓻𝓮'𝓼 𝓑𝓪𝓴𝓮𝓻𝔂        |");
			NewOrder.RecieptItems();
			Console.WriteLine(@"| 𝓣𝓱𝓪𝓷𝓴 𝔂𝓸𝓾 𝓯𝓸𝓻 𝔂𝓸𝓾𝓻 𝓫𝓾𝓼𝓲𝓷𝓮𝓼𝓼! |");
			Console.WriteLine(@"'------------------------------'");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}