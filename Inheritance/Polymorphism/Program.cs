using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	abstract class Enemy
	{
		public string name;
		public int health;
		public int damage;
		public abstract void Attack();
		public abstract void Scream();
	}
	class Orc : Enemy
	{
		public Orc() 
		{
			name = "Best Orc";
			damage = 1000;
			health = 212;
		}
		~Orc()
		{

		}
		public override void Attack()
		{
			Console.WriteLine("ORC ATTACK!"); 
		}
		public override void Scream()
		{
			Console.WriteLine("ORC SCREAM");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Orc k = new Orc();
			k.Attack();
			k.Scream();
		}
	}
}
