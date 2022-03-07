using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblOpg1Opg1;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        private Car c;
        [TestInitialize]
        public void SetUp()
        {
            c = new Car(1, "Mustang", 1000000000, "CY26065");
        }
        [TestMethod]
        public void TestConstructor()
        {
            Assert.AreEqual(c.Id, 1);
            Assert.AreEqual(c.Model, "Mustang");
            Assert.AreEqual(c.Price, 1000000000);
            Assert.AreEqual(c.LicensePlate, "CY26065");
        }
        [TestMethod]
        public void TestModel() 
        {
            c.Model = "Ford";
            Assert.AreEqual(c.Model, "Ford");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Model = "A");
        }
        [TestMethod]
        public void TestPrice()
        {
            c.Price = 1;
            Assert.AreEqual(c.Price, 1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Price = -1);
        }
        [TestMethod]
        public void TestLicensePlate()
        {
            c.LicensePlate = "aa";
            Assert.AreEqual(c.LicensePlate, "aa");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.LicensePlate = "aaaaaaaa");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.LicensePlate = "a");
        }
    }
}
