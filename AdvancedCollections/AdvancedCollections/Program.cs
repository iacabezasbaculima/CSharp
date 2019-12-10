using System;
using System.Collections;
using System.Collections.Generic;

namespace AdvancedCollections
{
	public class Cooking
	{
		private string recipe;
		private string ingredients;
		public string Ingredients
		{
			get { return ingredients; }
			set { ingredients = value; }
		}
		public virtual void ShoppingList() //allow method to be overridden by child class
		{
			Console.WriteLine("Ingredients: " + ingredients);
		}
	}

	public class Baking : Cooking //Inheret string Recipe and Ingredients from Cooking 
	{

		//Array of equipments
		string[] equipments = new string[6];
		public Hashtable data;

		public override void ShoppingList() //override method from parent class 
		{
			Console.WriteLine("Ingredients needed: " + Ingredients);
		}
		//Method for equipment Array
		public void equipmentArray()
		{
			equipments[0] = "Baking Tray";
			equipments[1] = "Cake Tin";
			equipments[2] = "Stand Mixer";
			equipments[3] = "Rolling Pin";
			equipments[4] = "Wodden Spoon";
			equipments[5] = "Bowl";
			Console.WriteLine(equipments[4]); //display value wodden spoon from array
			Console.WriteLine(equipments[5]);
		}
		public void CreateTable()
		{
			data = new Hashtable();
			data.Add("My Tool", "Baking Tray");
			data.Add("My Second Tool", "Cake Tin");
			data.Add(3, "Stand Mixer");
			data.Add(4, "RollingPin");
			data.Add(5, "Wooden Spoon");
			data.Add(6, "Bowl");
		}
		public void PrintTable()
		{
			foreach (DictionaryEntry item in data)
			{
				Console.WriteLine("{0}: {1}", item.Key, item.Value);
			}
		}
		Stack myStack;
		public void CreateStack()
		{
			myStack = new Stack(5);
			myStack.Push(5);
			myStack.Push("hello");
			myStack.Push(1.234f);
			myStack.Push('s');
			Console.WriteLine("\n-----------------------\nStack created:\n");
			foreach (var item in myStack)
			{ 
				Console.WriteLine(item);
			}
			myStack.Pop();
			myStack.Pop();
			myStack.Push("my new string");
			myStack.Push("my second string");
			Console.WriteLine("\nStack modified:\n");
			foreach (var item in myStack)
			{
				Console.WriteLine(item);
			}
		}
		Queue myQueue;
		public void CreateQueue()
		{
			myQueue = new Queue(4);
			myQueue.Enqueue("First customer");
			myQueue.Enqueue(2019);
			myQueue.Enqueue(1234589812821912);
			myQueue.Enqueue(2.189128989128912);
			Console.WriteLine("\n--------------------------\nQueue created:\n");
			foreach (var item in myQueue)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("\nQueue modified:\n");
			myQueue.Dequeue();
			myQueue.Dequeue();
			myQueue.Enqueue("Second Customer");
			myQueue.Enqueue("Third Customer");
			foreach (var item in myQueue)
			{
				Console.WriteLine(item);
			}
		}
	}

	public class Frying
	{
		ArrayList ls = new ArrayList();
		Dictionary<int, char> d = new Dictionary<int, char>();
		public Frying()
		{
			for (int i = 1; i < 6; i++)
			{
				d.Add(i, (char)i);
			}
			Console.WriteLine("\nDictionary created:\n");
			foreach (var item in d)
			{
				Console.Out.WriteLine(d[item.Key]);
			}
		}
	}
	class myGenericClass<T>
	{
		private T genericMember;

		public myGenericClass(T value)
		{
			genericMember = value;
		}
		public T GenericMethod(T genericParam)
		{
			return genericMember;
		}
		public T GenericProperty { get; set; }
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			int[,] game = new int[5, 7];
			
			for (int i = 0; i < game.GetLength(0); i++)
			{
				for (int t = 0; t < game.GetLength(1); t++)
				{
					game[i, t] = i + t;
					Console.Write(string.Format("{0}\n ", game[i, t]));
				}
			}
		}
	}
}
