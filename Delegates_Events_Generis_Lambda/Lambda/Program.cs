using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
	class Program
	{
		static void Main(string[] args)
		{
			Lambda lb = new Lambda();
		}
	}

	class Lambda
	{
		public int x;
		public int y;
		public int z;
		public int result;

		Func<int, int, int, int> three = (a, b, c) => a * b * c;

		Func<int, int, int> test = (a, b) =>
		{
			int product = a * b;
			return product;
		};
		Func<int, int, int> two = (a, b) => a * b;

		public Lambda()
		{
			x = 2;
			y = 4;
			z = 6;
			result = three(x, y, z);

			Console.WriteLine(two(x, y));
		}
	}
}
