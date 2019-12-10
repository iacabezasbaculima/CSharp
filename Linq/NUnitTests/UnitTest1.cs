using NUnit.Framework;
using App;
namespace NUnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}
		[TestCase("London", 6)]
		[TestCase(null, 91)]
		public void Test1(string city, int expected)
		{
			Assert.AreEqual(expected, Program.GetCustomers(city));
		}

		[TestCase(17)]
		public void TestProductsCountThatContainP(int expected)
		{
			Assert.AreEqual(expected, Program.GetProducts());
		}
		[TestCase(3)]
		public void TestProductsCountThatStartWithP(int expected)
		{
			Assert.AreEqual(expected, Program.GetProductsThatStartWithP());
		}
	}
}