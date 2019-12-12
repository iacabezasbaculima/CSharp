using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day2Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			IGame[] game = new IGame[2];
			game.Append(new Chess("Chess..."));
			game.Append(new Checkers("Checkers..."));
		}
	}

	public class Game
	{
		public string name;
		public Game(string name) { this.name = name; }
	}
	public class Chess : Game, IGame
	{
		public Chess(string name) : base(name) { }
		public string GetName() { return this.name; }
	}
	public class Checkers : Game, IGame
	{
		public Checkers(string name) : base (name)	{ }
		public string GetName() { return name; }
	}
	public interface IGame
	{
		string GetName();
	}
}
