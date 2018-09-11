using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
    [TestClass]
    public class SortKaffeTest
	{
        [TestMethod]
        public void TestSortKaffePris()
        {
			// Arrange
			SortKaffe sk = new SortKaffe();

			// Act
	        int pris = sk.Pris();

	        // Assert
			Assert.AreEqual(20, pris);
        }

		[TestMethod]
		public void TestSortKaffePrisRabat()
		{
			// Arrange
			SortKaffe sk = new SortKaffe(10);

			// Act
			int pris = sk.Pris();

			// Assert
			Assert.AreEqual(10, pris);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestSortKaffePrisForMegetRabat()
		{
			// Arrange
			SortKaffe sk = new SortKaffe(21);

			// Act
			int pris = sk.Pris();

			// Assert
			Assert.Fail();
		}
	}
}
