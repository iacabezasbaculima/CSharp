using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework101
{
	class Program
	{
		static void Main(string[] args)
		{
			using (Model1 md = new Model1())
			{
				Customer[] customerArray =
				{
					new Customer("56789", "Sparta Global", "Markson Aigbodi"),
					new Customer("54321", "Sparta Global", "David Rai"),
					new Customer("98765", "Sparta Global", "Spartan of the Year")
				};

				foreach (var c in customerArray)
				{
					md.Customers.Add(c);
					md.SaveChanges();
					Console.WriteLine("ADDED A NEW CUSTOMER.");
				}
			}
		}
	}
}
