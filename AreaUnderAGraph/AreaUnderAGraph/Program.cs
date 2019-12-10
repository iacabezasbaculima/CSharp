using System;

namespace AreaUnderAGraph
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.WriteLine(SimpsonsRule.GetArea(6, 0, 5));
		}
	}

	public class SimpsonsRule
	{
		/*
		 * Graph Parabola: y = x*x
		 Graph of Y=X*X  (can hard code this in)
         Points 0,1,2,3,4,5,6=N  (value of X)
         Value of Y : 0,1,4,9,16,25,36

		 Area: ([xmax - xmin]/ [Number of Points]) * ([Y of zeroth point] + [Y of last point])
				+ 4(odd-indexed points, i.e. N=1,3,5...)
				+ 2(even-indexed points i.e. N=2,4...)
		 */
		
		public static double GetArea(double b, double a, int n)
		{
			// odd: 1,9,25
			// even: 4, 16, 36
			
			double dx = (b - a) / n;

			double[] x = new double[] 
			{ 
				0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0
			};
			double[] fx = new double[]
			{
				0.0, 1.0, 4.0, 9.0, 16.0, 25.0, 36.0
			};

			double res = 0;

			for (int j = 0; j <= n; j++)
			{
				// add first and last 
				if (j == 0 || j == n)
					res += fx[j];
				// add odd values
				else if (j % 2 != 0)
					res += 4 * fx[j];
				// add even values
				else
					res += 2 * fx[j];
			}

			// compute area
			res = res * (dx / 3);

			return res;
		}
	}
}
