using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        private Account _target;

        [TestInitialize]
        public void TestInitialize()
        {
            _target = new Account("TestAcc", 155.22);
        }
        
        [TestMethod]
        public void Name_CanBeRead_ShouldReturnTestAcc()
        {
            // Assert
            Assert.AreEqual("TestAcc", _target.Name);
        }

        [TestMethod]
        public void Name_CanBeSet_ShouldReturnProperName()
        {
            // Act
            _target.Name = "ProperName";
            
            // Assert
            Assert.AreEqual("ProperName", _target.Name);
        }

        [TestMethod]
        public void Withdrawal_AmountCanBeReduced_ShouldReturn124Point06()
        {
            // Act
            _target.Withdrawal(31.16);

            // Assert
            Assert.AreEqual(124.06, _target.Balance());
        }

        [TestMethod]
        public void Deposit_AmountCanBeIncreased_ShouldReturn124Point06()
        {
            // Act
            _target.Deposit(45.78);

            // Assert
            Assert.AreEqual(201.00, _target.Balance());
        }

        [TestMethod]
        public void ToString_NameAndAmountCanBeDisplayed_ShouldReturnString()
        {
            // Assert
            Assert.AreEqual("TestAcc: 155.22", _target.ToString());
        }

        [TestMethod]
        public void Transfer_AmountCanBeTransfered_ShouldReturnNewValues()
        {
            // Arrange
            var target2 = new Account("TestAcc2", 10.00);
            
            // Act
            Program.Transfer(_target, target2, 15.50);
            
            // Assert
            Assert.AreEqual(139.72, _target.Balance());
            Assert.AreEqual(25.50, target2.Balance());
        }
    }
}
