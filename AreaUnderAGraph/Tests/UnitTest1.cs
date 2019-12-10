using NUnit.Framework;
using AreaUnderAGraph;

namespace Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(6, 72.0)]
		[TestCase(3, 14.0)] 
		[TestCase(5, 42.0)] 
		public void SimpsonsRuleTest(int n, double expected)
		{
			Assert.GreaterOrEqual(SimpsonsRule.GetArea(6, 0, n), expected);
		}
	}
}