using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	class Calculator
	{
		int num1, num2;

		public Calculator()
		{

		}
		public Calculator(int x, int y)
		{
			num1 = x;
			num2 = y;
		}

		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Subtract(int a, int b)
		{
			return a - b;
		}

		public int Divide(int a, int b)
		{
			if (b != 0)
				return a / b;
			else return 0;
		}
		public int Multiply(int a, int b)
		{
			return a * b;
		}
		public int UsingOutKeyword(int a, int b, out int c)
		{
			c = b - a;
			return a * b;
		}
	}
}
