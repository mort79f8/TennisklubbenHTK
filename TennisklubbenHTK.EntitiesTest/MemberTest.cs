using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisklubbenHTK.Entities;

namespace TennisklubbenHTK.EntitiesTest
{
    [TestClass]
    public class MemberTest
    {
        [TestMethod]
        public void ValidationFirstName_TooShortReturnsFalse()
        {
            // Arrange
            string name = "n";

            // Act
            var isFirstnameValid = Member.FirstnameValidation(name);

            // Assert
            Assert.IsFalse(isFirstnameValid.isValid);
        }

        [TestMethod]
        public void ValidationFirstName_NameContainDigitsReturnsFalse()
        {
            // Arrange            
            string name = "n123";

            // Act
            var isFirstnameValid = Member.FirstnameValidation(name);

            // Assert
            Assert.IsFalse(isFirstnameValid.isValid);
        }

        [TestMethod]
        public void ValidationFirstName_NameToolongReturnsFalse()
        {
            // Arrange            
            // name is 16 char. long
            string name = "qazxswedcvfrtgbn";

            // Act
            var isFirstnameValid = Member.FirstnameValidation(name);

            // Assert
            Assert.IsFalse(isFirstnameValid.isValid);
        }
    }
}
