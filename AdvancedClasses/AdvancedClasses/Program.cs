using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvancedClasses
{
	public class Program
	{
		public static void Main()
		{
			string input = Console.ReadLine();
			FileInfo n = new FileInfo(input+".txt");
			if(n.Exists)
			{
				n.Delete();
			}
			FileStream fs = n.Create();
			
			try
			{
				fs.Write(UTF8Encoding.UTF8.GetBytes("popopoopo"), 1, 5);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				fs.Close(); 
			}
		}
	}
	public class Eng45 : DivideByZeroException
	{
		public Eng45()
		{

		}
		public Eng45(string msg) : base(msg)
		{

		}
		public void divide(int a, int b)
		{
			//Eng45 ex = new Eng45();
			//dynamic v2 = ex.GetType().GetProperty("Value").GetValue(v1, null);
			try
			{
				int result = a / b;
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
