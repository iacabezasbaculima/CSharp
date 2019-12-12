using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IComparable_01
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new Item();
			var b = new Item();
			a.Name = "Bob";
			b.Name = "Carly";
			Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
			a.Name = "Carly";
			b.Name = "Carly";
			Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
			a.Name = "Edward";
			b.Name = "Carly";
			Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));

			/*Less than zero: This instance precedes obj in the sort order.
			  Zero: This instance occurs in the same position in the sort order as obj.
			  Greater than zero: This instance follows obj in the sort order.
			*/

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("============================= COMPARE BY LENGTH ==============================\n");
			ICompareByLength scribe1 = new Comparison();
			Console.WriteLine("Enter a word and press enter:\n");
			var input1 = Console.ReadLine();
			Console.WriteLine("Enter another word and press enter:\n");
			var input2 = Console.ReadLine();
			var output1 = scribe1.CompareByLength(input1, input2);
			switch (output1)
			{
				case 1: Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("{0} is greater than {1} ", input1, input2);
					break;
				case -1: Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("{0} is smaller than {1}", input1, input2);
					break;
				case 0:
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("{0} is equal to {1}", input1, input2);
					break;

			}
			Console.ForegroundColor = ConsoleColor.DarkMagenta;

			Console.WriteLine("============================= COMPARE BY NAME ============================");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Enter a word and press enter:\n");
			var	input3 = Console.ReadLine();
			Console.WriteLine("Enter another word and press enter:\n");
			var input4 = Console.ReadLine();
			ICompareByName scribe2 = new Comparison();
			var output2 = scribe2.CompareByName(input3, input4);
			switch (output2)
			{
				case 1:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("{0} follows {1} in the alphabet.", input3, input4);
					break;
				case -1:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("{0} precedes {1} in the alphabet..", input3, input4);
					break;
				case 0:
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("{0} is equal to {1} in the alphabet.", input3, input4);
					break;

			}
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
	public class Item : IComparable
	{
		public string Name;


		public int CompareTo(object o)
		{
			Item that = o as Item;
			return this.Name.CompareTo(that.Name);
		}
	}
	public interface ICompareByName
	{
		int CompareByName(string one, string two);
	}
	public interface ICompareByLength
	{
		int CompareByLength(string one, string two);
	}
	public class Comparison : ICompareByLength, ICompareByName
	{
		public string Name { get; set; }
		/// <summary>
		/// Returns 1 if both strings have the same length, -1 if not, 0 if they have same length
		/// </summary>
		/// <param name="one"></param>
		/// <param name="two"></param>
		/// <returns></returns>
		public int CompareByLength(string one, string two)
		{
			var length1 = one.Length;
			var length2 = two.Length;
			if (length1 > length2)
				return 1;
			else if (length1 < length2)
				return -1;
			else
				return 0;
		}
		/// <summary>
		/// Returns 1 if string one follows string two, -1 if viceversa, 0 if same
		/// </summary>
		/// <param name="one"></param>
		/// <param name="two"></param>
		/// <returns></returns>
		public int CompareByName(string one, string two)
		{
			var output = string.Compare(one, two);
			return output;
		}
	}
}