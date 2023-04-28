using DemoProject;
using DemoTestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoUnitTestProject
{
	[TestClass]
	public class UnitTest1 : TestBase
	{
		[TestMethod]
		public void TestMethod1()
		{
			var demoClass = new DemoClass();
			Assert.IsFalse(string.IsNullOrEmpty(demoClass.GetSomeString()));
		}
	}
}