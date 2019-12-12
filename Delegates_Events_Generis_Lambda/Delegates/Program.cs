using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	class Program
	{
		// A delegate (callback) is referency type data type,
		// it holds a reference to a method
		public delegate void Print(int value);
		// A function that has same return type and parameters as delegate above
		public static void PrintNumber(int num)
		{
			Console.WriteLine(num);
		}
		public static void PrintMoney(int num)
		{
			Console.WriteLine($"{"$ "}{num}");
		}
		// Pass delegate as a parameter
		public static void PrintHelper(Print delegateFunc, int numToPrint)
		{
			delegateFunc(numToPrint);
		}
		static void Main(string[] args)
		{
			// Initialize a delegate type
			Print printDel = null; // OR
								   //Print printDel2 = new Print(PrintNumber);
								   // Invoke a delegate
								   //printDel(10000);	// OR
								   //printDel.Invoke(10000);

			// Invoke a delegate as a parameter
			//PrintHelper(PrintNumber, 200);

			// Multicast delegate: point to many functions
			printDel += PrintNumber; // add function to call
			printDel += PrintMoney;  // add function to call

			printDel(1000);

			printDel -= PrintNumber; // remove function

			printDel(1000);
		}
	}
}

