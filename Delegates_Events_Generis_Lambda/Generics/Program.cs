using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	class Program
	{
		static int GetNum(int num)
		{
			return num;
		}
		static void PrintNum(int a)
		{
			Console.WriteLine(a);
		}
		static void Main(string[] args)
		{
			PrintNum(GetNum(2));

			Console.WriteLine();

			MyGenericClass.Print("hello world");
			MyGenericClass.Print(2019);
			MyGenericClass.Print(1.3444f);

			Console.WriteLine();

			// Passed by reference
			string str = "Hello, World";
			int num = 2019;
			float num2 = 9.81f;
			MyGenericClass.Print(str);
			MyGenericClass.Print(num);
			MyGenericClass.Print(num2);
			
			Console.WriteLine();

			// An overloaded generic method with three arbitray types as parameters
			MyGenericClass.Print(2, "hello", 'A');
		}
	}

	public static class MyGenericClass
	{
		/// <summary>
		/// A generic method that can print any type to the console
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value"></param>
		public static void Print<T>(T value)
		{
			Console.WriteLine(value);
		}

		public static void Print<T>(ref T value)
		{
			Console.WriteLine(value.ToString());
		}
		public static void Print<T, U, V> (T t, U u, V v)
		{
			Console.WriteLine($"{t, -10}{u, -10}{v, -10}");
		}
	}
}
