using NUnit.Framework;
using FibonacciApp;
namespace Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(3,3)]
		[TestCase(4, 5)]
		[TestCase(7, 21)]
		public void Test1(int nth, int expected)
		{
			Assert.AreEqual(expected, Fibonacci.F(nth));
		}
	}
}