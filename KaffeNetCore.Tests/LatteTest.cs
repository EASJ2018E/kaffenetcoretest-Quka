using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
	[TestClass]
	public class LatteTest
	{
		[TestMethod]
		public void TestLatteMlMælk()
		{
			// Arrange
			Latte l = new Latte();

			// Act
			int mlmælk = l.MlMælk();

			// Assert
			Assert.AreEqual(120, mlmælk);
		}

		[TestMethod]
		public void TestLattePris()
		{
			// Arrange
			Latte l = new Latte();

			// Act
			int pris = l.Pris();

			// Assert
			Assert.AreEqual(40, pris);
		}
	}
}