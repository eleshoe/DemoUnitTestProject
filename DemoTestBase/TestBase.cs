using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoTestBase
{
	// This is a base/helper class for unit tests
	public abstract class TestBase
	{
		public TestContext TestContext { get; set; }

		public void SomeHelperMethod()
		{
			// Codes
		}
	}
}
