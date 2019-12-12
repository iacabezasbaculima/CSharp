using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RawSQL
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer[] list =
			{
				new Customer("12345", "Spartan", "SG")
			};

			MySQLClient.Create(list[0]);
		}
	}
	public class MySQLClient
	{
		public static void Create(Customer customerObj)
		{
			string clientSocket = "" +
				"Data Source=localhost;" +
				"Initial Catalog=Northwind;" +
				"Persist Security Info=True;" +
				"User ID=sa;" +
				"Password=Passw0rd2018";

			using (SqlConnection con = new SqlConnection(clientSocket))
			{
				con.Open();
				Console.WriteLine(con.State);
				try
				{
					MySQLClient.UpdateWithStoreProcedure(con, "2019", "KING LEONIDAS", "THIS IS SPRTA");
				}
				catch (SqlException ex)
				{ 
					Console.WriteLine("EXCEPTION::SQL_ERROR : " + ex.Message);
				}
			}
		}
		/// <summary>
		/// Retrieve data from a table in database
		/// </summary>
		/// <param name="con"></param>
		/// <param name="c"></param>
		public static void SelectQuery(SqlConnection con, Customer c)
		{
			string q = string.Format("SELECT * FROM Customers WHERE CustomerID = '2019'");
			using (SqlCommand cmd = new SqlCommand(q , con))
			{
				SqlDataReader data = cmd.ExecuteReader();
				while (data.Read())
				{
					c.Id = data["CustomerID"].ToString();
					c.CompanyName = data["CompanyName"].ToString();
					c.Name = data["ContactName"].ToString();
				}

				Console.WriteLine("SELECT finished: {0}, {1}, {2}.", c.Id, c.CompanyName, c.Name);
			}
		}
		/// <summary>
		/// Insert data into a table in database
		/// </summary>
		/// <param name="con"></param>
		/// <param name="c"></param>
		public static void InsertQuery(SqlConnection con, Customer c)
		{
			string q = string.Format("INSERT INTO Customers (CustomerID, CompanyName, ContactName) Values ('{0}', '{1}', '{2}')", c.Id, c.CompanyName, c.Name);
			using (SqlCommand cmd = new SqlCommand(q, con))
			{
				int result = cmd.ExecuteNonQuery();
				Console.WriteLine("INSERT completed successfully: {0}.", result);
			}
		} 
		/// <summary>
		/// Update data in a table in database
		/// </summary>
		/// <param name="con"></param>
		/// <param name="param"></param>
		public static void UpdateQuery(SqlConnection con, string param)
		{
			string q = string.Format("UPDATE Customers SET CustomerID = '{0}' WHERE CustomerID = '12345'", param);
			using (SqlCommand cmd = new SqlCommand(q, con))
			{
				int result = cmd.ExecuteNonQuery();
				Console.WriteLine("UPDATE completed successfully: {0}", result);
			}
		}
		static void UpdateWithStoreProcedure(SqlConnection con, string withID, string newContactName, string newCompanyName)
		{
			using (SqlCommand cmd = new SqlCommand("UpdateCustomer", con))
			{
				// Tell program that we want to run a stored procedure
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				// Change item with CustomerID given by...
				cmd.Parameters.AddWithValue("ID", withID);
				// Replace ContactName
				cmd.Parameters.AddWithValue("NewName", newContactName);
				cmd.Parameters.AddWithValue("NewCompany", newCompanyName);
				// Run 
				int result = cmd.ExecuteNonQuery();
				Console.WriteLine("UPDATE WITH STORED PROCEDURE finished: {0}", result);
			}
		}
		/// <summary>
		/// Delete data in a table in database
		/// </summary>
		/// <param name="con"></param>
		public static void DeleteQuery(SqlConnection con, string tableName, string rowName, string data)
		{
			string q = string.Format("DELETE FROM {0} WHERE {1} = '{2}'", tableName, rowName, data);

			using (SqlCommand cmd = new SqlCommand(q, con))
			{
				int result = cmd.ExecuteNonQuery();
				Console.WriteLine("DELETE completed : {0}.", result);
			}
		}
		/// <summary>
		/// Create a table in database
		/// </summary>
		/// <param name="con"></param>
		public static void CreateQuery(SqlConnection con, string tableName, string col1, string col1type, string col2, string col2type)
		{
			//string q = string.Format("CREATE TABLE {0} ");
			//using (SqlCommand cmd = new SqlCommand(q, con))
			//{
			//	int result = cmd.ExecuteNonQuery();
			//	Console.WriteLine("CREATE completed: {0}", result);
			//}
		}
	}
	public class Customer
	{
		private string id;
		private string name;
		private string companyName;
		public Customer(string id, string name, string companyName)
		{
			this.id = id;
			this.name = name;
			this.companyName = companyName;
		}
		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string CompanyName { get => companyName; set => companyName = value; }
	}
}
