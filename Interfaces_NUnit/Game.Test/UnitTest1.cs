using System;
using NUnit.Framework;
using Week3Day2Homework;
namespace Game.Test
{
	[TestFixture]
	public class UnitTest1
	{
		IGame[] games =
		{
			new Chess("CHECKERS IS THE BEST GAME IN THE WORLD."),
			new Checkers("CHECKERS IS THE BEST GAME IN THE WORLD.")
		};

		[Test]
		public void TestMethod1()
		{
			foreach (var item in games)
			{
				Assert.AreEqual("CHECKERS IS THE BEST GAME IN THE WORLD.", item.GetName());
			}
			//Assert.AreEqual("CHECKERS IS THE BEST GAME IN THE WORLD.", games[0].GetName());
		}
	}
}


