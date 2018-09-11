using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
	[TestClass]
	public class FlatWhiteTest
	{
		[TestMethod]
		public void TestFlatWhiteMlMælk()
		{
			// Arrange
			FlatWhite fw = new FlatWhite();

			// Act
			int mlmælk = fw.MlMælk();

			// Assert
			Assert.AreEqual(160, mlmælk);
		}

		[TestMethod]
		public void TestFlatWhitePris()
		{
			// Arrange
			FlatWhite fw = new FlatWhite();

			// Act
			int pris = fw.Pris();

			// Assert
			Assert.AreEqual(45, pris);
		}

		[TestMethod]
		public void TestFlatWhiteStyrke()
		{
			// Arrange
			FlatWhite fw = new FlatWhite();

			// Act
			string styrke = fw.Styrke();

			// Assert
			Assert.AreEqual("Mild", styrke);
		}
	}
}