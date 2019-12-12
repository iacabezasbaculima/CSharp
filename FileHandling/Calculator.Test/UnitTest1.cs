using NUnit.Framework;

namespace Calculator.Test
{
	[TestFixture]
	public class UnitTest1
	{
		Calculator c = new Calculator();

		[Test]
		public void TestAddMethod()
		{
			Assert.AreEqual(4, c.Add(2, 2));
		}
		[Test]
		public void TestSubtractMethod()
		{
			Assert.AreEqual(4, c.Subtract(6, 2));
		}
		[Test]
		public void TestMultiply()
		{
			Assert.AreEqual(32, c.Multiply(4, 8));
		}
		[Test]
		public void TestDivideMethod()
		{
			Assert.AreEqual(4, c.Divide(8, 2));
		}
	}
}
