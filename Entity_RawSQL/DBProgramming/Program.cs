using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBProgramming
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer[] list = 
			{
				new Customer { CustomerID = "21225", CompanyName = "THIS IS SPARTA", ContactName = "SPARTAN WARRIOR" },
				new Customer { CustomerID = "8746", CompanyName = "THIS IS SPARTA", ContactName = "SPARTAN WARRIOR TWO"},
				new Customer { CustomerID = "22222", CompanyName = "THIS IS SPARTA", ContactName = "SPARTAN WARRIOR THREE"}
			};

			using (Model1 md = new Model1())
			{
				//foreach (var item in list)
				//{
				//	md.Customers.Add(item);
				//}
				//md.SaveChanges();
				//Console.WriteLine("COMPLETED SUCCESSFULLY.");

				// LINQ Syntax
				//var result = list.Where(a => Int32.Parse(a.CustomerID) >= 20000).ToList();
				//Console.WriteLine("RESULT: " + result[0].CustomerID + ", " + result[1].CustomerID);
				var result = md.Customers.ToList();
				
				foreach (var item in result)
				{
					Console.WriteLine(item.ContactName);
				}
			}
		}
	}
}
