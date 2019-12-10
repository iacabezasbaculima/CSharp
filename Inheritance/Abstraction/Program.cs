using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	class Program
	{
		//private List<string> myList;
		static void Main(string[] args)
		{
			Calculator c = new Calculator();
			Console.WriteLine(c.Add(2,4));
			Console.WriteLine(c.Subtract(56, 32));
			Console.WriteLine(c.Multiply(23231, 843));
			Console.WriteLine(c.Divide(120, 5));
			Console.WriteLine("Result: " + c.UsingOutKeyword(10, 5, out int extra) + " | Extra: " + extra);
		}
	}
}
