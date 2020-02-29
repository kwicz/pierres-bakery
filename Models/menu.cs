using System.Collections.Generic;

namespace Bakery.Models
{
	public class Menu
	{
		// Bakery Menu
		public static Dictionary<string, int> menuItems = new Dictionary<string, int>(6){
			{"bagel", 2},
			{"donut", 1},
			{"cake", 4},
			{"milk", 1},
			{"coffee", 2},
			{"wine", 6},
			{"bread", 5},
			{"pastry", 2}
					};
	}

	// Bread Deal
	public class Bread
	{
		public int Cost { get; set; }

		public Bread()
		{
			Cost = 5;
		}

		public int OrderBread(int amount)
		{
			int total = 0;
			for (int i = 1; i <= amount; i++)
			{
				if (i % 3 != 0)
				{
					total += Cost;
				}
			}
			return total;
		}
	}

	// Pastry Deal
	public class Pastry
	{
		public int Cost { get; set; }

		public Pastry()
		{
			Cost = 2;
		}

		public int OrderPastries(int amount)
		{
			int total = 0;
			for (int i = 1; i <= amount; i++)
			{
				if (i % 3 != 0)
				{
					total += Cost;
				}
				else
				{
					total++;
				}
			}
			return total;
		}
	}
}