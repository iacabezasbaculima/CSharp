using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Zoo
	{
		public string Address;
		public string Postcode;
		public int NumberOfAnimals;
		public int NumberOfEmployees;
		public string OpenedSince;
	}
	public class Animal : Zoo
	{
		public string Name;
		public string Gender;
		public int Age;
	}
	public class Lion : Animal
	{
		public bool HasMane;
		public bool LikesToBitePeople;
		public string FavouriteMeat;
	}
	public class Employee : Zoo
	{
		public string Name;
		public int Age;
		public int Id;
	}
	public class CustomerAssistant : Employee
	{
		public int AmountOfTicketsSold;
		public bool IsAtTill;
		public bool HadLunchBreak;
	}
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("These are my values: " + args[0] + ", " + args[1] + ", " + args[2]);
		}
	}
}
