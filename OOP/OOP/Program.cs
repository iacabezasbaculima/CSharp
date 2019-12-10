using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP
{
	class Human
	{
		private int numberOfHours;
		private int age;
		private int activityLevel;

		public Human()
		{
			numberOfHours = 123;
			age = 123;
			activityLevel = 123;
		}
		public Human(int numberOfHours = 99, int age = 99, int activityLevel = 99)
		{
			this.numberOfHours = numberOfHours;
			this.age = age;
			this.activityLevel = activityLevel;
		}
		public void printHumanAttributes()
		{
			Console.WriteLine("Number of Hours: {0}, Age: {1}, Activity Level: {2}", numberOfHours, age, activityLevel);
		}
		public int NumberOfHours { get => numberOfHours; set => numberOfHours = value; }
		public int Age { get => age; set => age = value; }
		public int ActivityLevel { get => activityLevel; set => activityLevel = value; }
	}
	class WorkingClass : Human
	{
		public WorkingClass()
		{

		}
		public WorkingClass(int numberOfHours, int age, int activityLevel) : base(numberOfHours, age, activityLevel)
		{
			//base.NumberOfHours = numberOfHours;
			//base.Age = age;
			//base.ActivityLevel = activityLevel;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Human human1 = new Human();
			Human human2 = new Human(5, 25, 60);
			WorkingClass worker = new WorkingClass();

			human1.printHumanAttributes();
			human2.printHumanAttributes();
			worker.printHumanAttributes();

			StringBuilder stb = new StringBuilder("Superman");
			stb.Append(" IS THE BEST");
			Console.WriteLine(stb);

			ArrayList s = new ArrayList(3);
			s.Add(2);
			int x = (int) s[0];

		}
	}
}
