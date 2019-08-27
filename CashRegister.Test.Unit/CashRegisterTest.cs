using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CashRegister.Test.Unit
{
    [TestFixture]
    public class CashRegisterTest
    {
        private Register uut;

        [SetUp]
        public void Setup()
        {
            uut = new Register();
        }

        [Test]
        public void ctor_NothingAdded_NoOfItemsIs0()
        {
            Assert.That(uut.NoOfItems, Is.Zero);
        }

        [Test]
        public void AddItem_OneItem_NoOfItemsReturns1()
        {
            // Arrange in Setup

            // Act
            uut.AddItem(12.55);

            // Assert
            Assert.That(uut.GetNItems(), Is.EqualTo(1));

        }

        [Test]
        public void AddItem_OneItem_TotalIsCorrect()
        {
            uut.AddItem(11.44);

            Assert.That(uut.GetTotal(), Is.EqualTo(11.44));
        }

        [Test]
        public void AddItem_TwoItems_NumberIs2()
        {
            uut.AddItem(1.25);
            uut.AddItem(15.75);

            Assert.That(uut.NoOfItems, Is.EqualTo(2));
        }

    }
}
