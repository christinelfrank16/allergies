
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

        [TestMethod]
        public void GetUserInput_ConvertToNumber_Number()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            double actual = allergen.GetUserInput("2");

            // Assert
            Assert.AreEqual(2.0, actual);
        }

                [TestMethod]
        public void GetUserInput_RejectNonIntNumber_ErrorNumber()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            double actual = allergen.GetUserInput("2.2");

            // Assert
            Assert.AreEqual(-0.1, actual);
        }

        [TestMethod]
        public void GetUserInput_ConvertToNumber_ErrorNumber()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            double actual = allergen.GetUserInput("forty");

            // Assert
            Assert.AreEqual(-0.1, actual);
        }

        [TestMethod]
        public void ShowAllergens_RetrunMultipleAllergens_Strin()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            string actual = allergen.ShowAllergens(9.0);

            // Assert
            Assert.AreEqual("strawberries, eggs", actual);
        }
        
        [TestMethod]
        public void ShowAllergens_RetrunUnknownAllergens_Strin()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            string actual = allergen.ShowAllergens(257.0);

            // Assert
            Assert.AreEqual("unknown allergen, eggs", actual);
        }

        [TestMethod]
        public void ShowAllergens_UnknownAllergens_String()
        {
            // Arrange
            Allergen allergen = new Allergen();
            // Act
            string actual = allergen.ShowAllergens(10001.0);
            string result = allergen.UnknownReplacer(actual);

            // Assert
            Assert.AreEqual("unknown allergen, eggs", result);
        }
    }
}