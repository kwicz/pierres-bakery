
namespace Bakery.Models
{
	public class Bread
	{
		public double Cost { get; set; }

		public Bread()
		{
			Cost = 5.00;
		}

		public double OrderBread(int amount)
		{
			double total = 0;
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
	public class Pastry
	{
		public double Cost { get; set; }

		public Pastry()
		{
			Cost = 2.00;
		}

		public double OrderPastries(int amount)
		{
			double total = 0;
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