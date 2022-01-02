using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using PhoneBook;

namespace Phonebook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [TestInitialize]
        public void TestInitialize()
        {
            _target = new PhoneDirectory();
        }
        
        [TestMethod]
        public void Find_NameLeo_ShouldReturnTrue()
        {
            // Arrange
            var name = "Leo";
            var number = "00353841614964";

            // Act
            _target.PutNumber(name, number);

            // Assert
            Assert.AreEqual(true, _target.Find(name));
        }

        [TestMethod]
        public void GetNumber_NameRalphNumber00352645655812_ShouldReturnNumber00352645655812()
        {
            // Arrange
            var name = "Ralph";
            var number = "00352645655812";
            _target.PutNumber(name, number);

            // Act
            var result = _target.GetNumber(name);

            // Assert
            Assert.AreEqual(number, result);
        }

        [TestMethod]
        public void GetNumber_Mary_ShouldReturnNull()
        {
            // Act
            var result = _target.GetNumber("Mary");

            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void PutNumber_NameJohnNumber0035136429812_ShouldContainRecordJohn()
        {
            // Arrange
            var name = "John";
            var number = "0035136429812";

            // Act
            _target.PutNumber(name, number);

            // Assert
            Assert.AreEqual(number, _target.GetNumber(name));
        }

        [TestMethod]
        public void PutNumber_NameIsNull_ThrowsException()
        {
            // Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber(null, "0052123658547"));
        }

        [TestMethod]
        public void PutNumber_NumberIsNull_ThrowsException()
        {
            // Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber("Anne", null));
        }
    }
}
