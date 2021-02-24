using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Helpers;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class TemperatureConverterTests
    {
        // Celcius to ...
        [TestMethod]
        public void TestCelciusToFahrenheit()
        {
            var temperatureConverter = new TemperatureConverter();
            temperatureConverter.SetTemperature(12.0);
            Assert.AreEqual(53.6, temperatureConverter.CelciusToFahrenheit());
        }

        [TestMethod]
        public void TestCelciusToKelvin()
        {
            var temperatureConverter = new TemperatureConverter();
            temperatureConverter.SetTemperature(10.0);
            Assert.AreEqual(283.15, temperatureConverter.CelciusToKelvin());
        }

        // Fahrenheit to ...
        [TestMethod]
        public void TestFahrenheitToCelcius()
        {
            var temperatureConverter = new TemperatureConverter();
            temperatureConverter.SetTemperature(41.0);
            Assert.AreEqual(5.0, temperatureConverter.FahrenheitToCelcius());
        }

        [TestMethod]
        public void TestFahrenheitToKelvin()
        {
            var temperatureConverter = new TemperatureConverter();
            temperatureConverter.SetTemperature(41.0);
            Assert.AreEqual(278.15, temperatureConverter.FahrenheitToKelvin());
        }

        // Kelvin to ...
        [TestMethod]
        public void TestKelvinToCelcius()
        {
            var temperatureConverter = new TemperatureConverter();
            temperatureConverter.SetTemperature(345.15);
            Assert.AreEqual(72.0, temperatureConverter.KelvinToCelcius());
        }

        [TestMethod]
        public void TestKelvinToFahrenheit()
        {
            var temperatureConverter = new TemperatureConverter();
            temperatureConverter.SetTemperature(278.15);
            Assert.AreEqual(41.0 , temperatureConverter.KelvinToFahrenheit());
        }
    }
}
