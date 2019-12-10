using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;	// use ToList with dbContext

namespace App
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Customer> customers = new List<Customer>();
			List<ModifiedCustomer> modCustomers = new List<ModifiedCustomer>();
			List<Product> products = new List<Product>();
			List<Category> categories = new List<Category>();
			using (var db = new Northwind())
			{
				customers = db.Customers.ToList();
				#region Simple LINQ
				// IEnumerable: returend when we query a local array/collection
				var selectedCustomers = from customer in customers select customer;
				
				// IQueryable: returned when we query a remote array/collection (i.e. database table)
				// Data is not returned yet by this query below, called Lazy Loading
				var selectedCustomers2 = from customer in db.Customers select customer;
				
				// Force data to be returned as a List collection
				selectedCustomers2.ToList();
				
				// Everything combined in one statement
				var selectedCustomers3 = (from customer in db.Customers select customer).ToList();
				
				// A simple sql-style query
				var selectedCustomers4 = (from customer in db.Customers 
				where customer.City=="London" || customer.City=="Berlin" 
				orderby customer.ContactName select customer).ToList();
				
				// Print customers selected above
				PrintCustomers(selectedCustomers4);

				// Create customer object output
				Console.WriteLine("------------------------------------------------------------------------------------------------------------");
				var selectedCustomer5 = (from customer
										in db.Customers
										select new
										{
											Name = customer.ContactName,
											Location = customer.City + " " + customer.Country
										}).Take(10).ToList();
				selectedCustomer5.ForEach(c => Console.WriteLine($"{c.Name,-25}{c.Location,-20}"));
				// Using a custom class for customer
				var modifiedCustomer = (from c
										in db.Customers
					select new ModifiedCustomer(c.ContactName, c.City + " "+c.Country)).ToList();
				modCustomers = modifiedCustomer;
				Console.WriteLine("------------------------------------------------------------------------------------------------------------");
				// Grouping
				// Group and list all customer by city
				// city...count(customer)
				var groupCustomers = (from c in db.Customers
									  group c by c.City into Cities
									  where Cities.Count() > 1
									  orderby Cities.Count() descending
									  select new
									  {
										  City = Cities.Key,
										  Count = Cities.Count()
									  }).ToList();
				groupCustomers.ForEach(c => Console.WriteLine($"{c.City,-15}{c.Count}"));
				Console.WriteLine("------------------------------------------------------------------------------------------------------------");
				// Join
				// products with categoryid => category name
				Console.WriteLine("\n\nList of Products Inner Join Category Showing Name\n");
				var join = (from p in db.Products
						   join c in db.Categories
						   on p.CategoryID equals c.CategoryID
						   select new
						   {
							  Id = p.ProductID,
							  Name = p.ProductName,
							  Category = c.CategoryName
						   }).ToList();
				join.ForEach(p => Console.WriteLine($"{p.Id, -10}{p.Name, -40}{p.Category}"));

				Console.WriteLine($"\n\nPrint off the same list with much smarter \"dot\" join notation to join tables.\n");
				products = db.Products.ToList();
				categories = db.Categories.ToList();
				products.ForEach(p => Console.WriteLine($"{p.ProductID, -15}{p.ProductName, -40}{p.Category.CategoryName}"));

				Console.WriteLine($"\n\nList Categories with Count of Products And Sub-List of Product Names\n");
				categories.ForEach(c =>
				{
					Console.WriteLine($"{c.CategoryID,-5}" +
					$"{c.CategoryName,-15} has {c.Products.Count} products");
					// c.Products is a join: Category with Product
					foreach (var p in c.Products)
					{
						Console.WriteLine($"\t\t\t\t{p.ProductID, -5}{p.ProductName, -40}");
					}
				});
				Console.WriteLine($"\n\nLINQ LAmbda Notation:\n");
				customers = db.Customers.ToList();
				Console.WriteLine($"Count is {customers.Count}");
				Console.WriteLine($"Count is {db.Customers.Count()}");

				// Distinct
				Console.WriteLine($"\n\nList of distinct cities.\n");
				Console.WriteLine($"Using IQueryable.Select to \"SELECT\" one column.");
				var cityList = db.Customers.Select(c => c.City).Distinct().OrderBy(c => c).ToList();
				cityList.ForEach(city => Console.WriteLine(city));

				Console.WriteLine($"\n\nContains (same as SQL LIKE)\n");	
				var cityListFiltered = db.Customers.Select(c => c.City)
					.Where(c => c.Contains("o"))
					.Distinct()
					.OrderBy(c => c)
					.ToList();

				cityListFiltered.ForEach(i => Console.WriteLine(i));
				#endregion
			}
			static void PrintCustomers(List<Customer> customers)
			{ customers.ForEach(i => Console.WriteLine($"{i.ContactTitle,-25}{i.ContactName,-20}{i.City,-15}{i.CompanyName}"));}

		}

		#region Test Number of Customers 
		public static int GetCustomers(string city)
		{
			using (var db = new Northwind())
			{
				if (string.IsNullOrEmpty(city))
				{
					return db.Customers.Count();
				}
				else 
					return db.Customers.Where(c => c.City == "London").Count();
			}
		}
		#endregion

		#region Test Number of Products
		public static int GetProducts()
		{
			using (var db = new Northwind())
			{
				return db.Products.Where(p => p.ProductName.Contains("p")).Count();
			}
		}

		public static int GetProductsThatStartWithP()
		{
			using (var db = new Northwind())
			{
				return db.Products.Where(p => p.ProductName.StartsWith("P")).Count();
			}
		}
		#endregion
	}

	#region Modified Customer Class
	public class ModifiedCustomer
	{
		public string Name { get; set; }
		public string Location { get; set; }
		public ModifiedCustomer(string name, string location)
		{
			Name = name;
			Location = location;
		}
	}
	#endregion

	#region Explanation
	/*
	 1. Read Northwind using Entity Core 2.1.1
	 2. Basic LINQ
	 3. Advanced LINQ with Lambda

	 Nuget Packages:
	 Microsoft.EntityFramework.Core/ sqlserver / design v=2.1.1


	 */

	#endregion

	#region DatabaseContextAndClasses
	// connect to database

	public partial class Customer
	{
		public string CustomerID { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
	}
	public class Category
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public virtual ICollection<Product> Products { get; set; }

		public Category()
		{
			this.Products = new List<Product>();
		}
	}

	public class Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int? CategoryID { get; set; }
		public virtual Category Category { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal? UnitPrice { get; set; } = 0;
		public short? UnitsInStock { get; set; } = 0;
		public short? UnitsOnOrder { get; set; } = 0;
		public short? ReorderLevel { get; set; } = 0;
		public bool Discontinued { get; set; } = false;
	}

	public class Northwind : DbContext
	{
		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Customer> Customers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=Northwind;" + "Integrated Security = true;" + "MultipleActiveResultSets=true;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>()
				.Property(c => c.CategoryName)
				.IsRequired()
				.HasMaxLength(15);

			// define a one-to-many relationship
			modelBuilder.Entity<Category>()
				.HasMany(c => c.Products)
				.WithOne(p => p.Category);

			modelBuilder.Entity<Product>()
				.Property(c => c.ProductName)
				.IsRequired()
				.HasMaxLength(40);

			modelBuilder.Entity<Product>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Products);
		}
	}
	#endregion
}
