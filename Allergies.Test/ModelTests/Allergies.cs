
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies.Models;
using System;

namespace Allergies.Tests
{
    [TestClass]
    public class AllergenTest
    {

        [TestMethod]
        public void ShowAllergens_ReturnAllergenList_String()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            string actual = allergen.ShowAllergens(2.0);

            // Assert
            Assert.AreEqual("peanuts", actual);
        }
    }
}