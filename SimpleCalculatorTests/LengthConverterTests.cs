using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Helpers;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class LengthConverterTests
    {
        // Milimeters to ....
        [TestMethod]
        public void TestMilimetersToCentimeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(120.0);
            Assert.AreEqual(12.0, lengthConverter.MilimetersToCentimeters());
        }

        [TestMethod]
        public void TestMilimetersToMeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(120.0);
            Assert.AreEqual(0.12, lengthConverter.MilimetersToMeters());
        }

        [TestMethod]
        public void TestMilimetersToKilometers()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(1200.0);
            Assert.AreEqual(0.0012, lengthConverter.MilimetersToKilometers());
        }

        // Centimeters to ...
        [TestMethod]
        public void TestCenimetersToMilimeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(11.1);
            Assert.AreEqual(111.0, lengthConverter.CentimetersToMilimeters());
        }

        [TestMethod]
        public void TestCentimetersToMeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(321);
            var result = lengthConverter.CentimetersToMeters();
            Assert.AreEqual(3.21, result);
        }

        [TestMethod]
        public void TestCentimetersToKilometers()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(54433.33);
            Assert.AreEqual(0.5443333, lengthConverter.CentimetersToKilometers());
        }

        // Kilometers to ...
        [TestMethod]
        public void TestKilometersToMilimeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(0.5);
            Assert.AreEqual(500000.0, lengthConverter.KilometersToMilimeters());
        }

        [TestMethod]
        public void TestKilometersToCentimeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(1.5);
            Assert.AreEqual(150000.0, lengthConverter.KilometersToCentimeters());
        }

        [TestMethod]
        public void TestKilometersToMeters()
        {
            var lengthConverter = new LengthConverter();
            lengthConverter.SetLength(12.5);
            Assert.AreEqual(12500.0, lengthConverter.KilometersToMeters());
        }
    }
}
