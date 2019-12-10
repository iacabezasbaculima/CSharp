using System;

namespace FibonacciApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class Fibonacci
	{
		// the first term (1) is not counted so the first index is the second 1, i.e. 1, 1, 2, 3...
		public static int F(int n)
		{
			if (n > 1)
			{
				var result = F(n - 1) + F(n - 2);
				return result;
			}
			else return 1;
		}
	}
}
