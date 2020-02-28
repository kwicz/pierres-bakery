using System;

namespace Bakery.Models
{

	public class Bread
	{
		public double Cost { get; set; }

		public Bread()
		{
			Cost = 5.00;
		}

		public OrderBread(int amount)
		{
			Bread bread = new Bread();
			int total = bread.Cost * amount;
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

		public OrderPastries(int amount)
		{
			Pastry pastry = new Pastry();
			int total = pastry.Cost * amount;
			return total;
		}

	}

}