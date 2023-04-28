using DemoProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoUnitTestProject
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void TestMethod1()
		{
			var demoClass = new DemoClass();
			Assert.IsFalse(string.IsNullOrEmpty(demoClass.GetSomeString()));
		}
	}
}
