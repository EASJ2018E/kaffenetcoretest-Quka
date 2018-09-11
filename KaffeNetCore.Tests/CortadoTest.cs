using System;
using System.Collections.Generic;
using System.Text;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.Tests
{
	[TestClass]
    public class CortadoTest
    {
	    [TestMethod]
	    public void TestCortadoMlMælk()
	    {
		    // Arrange
		    Cortado c = new Cortado();

			// Act
			int mlmælk = c.MlMælk();

			// Assert
			Assert.AreEqual(25, mlmælk);
	    }

	    [TestMethod]
	    public void TestCortadoPris()
	    {
		    // Arrange
		    Cortado c = new Cortado();

		    // Act
		    int pris = c.Pris();

		    // Assert
		    Assert.AreEqual(25, pris);
	    }
	}
}
