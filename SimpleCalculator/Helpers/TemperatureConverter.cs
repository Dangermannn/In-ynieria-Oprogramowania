using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Helpers
{
    public class TemperatureConverter
    {
        double Temperature;
        
        public double CelciusToFahrenheit() => (Temperature * 9.0 / 5.0) + 32.0;

        public double CelciusToKelvin() => Temperature + 273.15;

        public double FahrenheitToCelcius() => (Temperature - 32.0) * 5.0 / 9.0;
        public double FahrenheitToKelvin() => (Temperature - 32.0) * 5.0 / 9.0 + 273.15;

        public double KelvinToCelcius() => Temperature - 273.15;
        public double KelvinToFahrenheit() => (Temperature - 273.15) * 9.0 / 5.0 + 32.0;

        public void SetTemperature(double temp) => Temperature = temp;

        public double HandleConverter(string unitFrom, string unitTo)
        {
            switch(unitFrom)
            {
                case TemperatureUnits.Celcius:
                    switch (unitTo)
                    {
                        case TemperatureUnits.Celcius:
                            return Temperature;
                        case TemperatureUnits.Fahrenheit:
                            return CelciusToFahrenheit();
                        case TemperatureUnits.Kelvin:
                            return CelciusToKelvin();
                        default:
                            return -1;
                    }
                case TemperatureUnits.Fahrenheit:
                    switch (unitTo)
                    {
                        case TemperatureUnits.Celcius:
                            return FahrenheitToCelcius();
                        case TemperatureUnits.Fahrenheit:
                            return Temperature;
                        case TemperatureUnits.Kelvin:
                            return FahrenheitToKelvin();
                        default:
                            return -1;
                    }
                case TemperatureUnits.Kelvin:
                    switch (unitTo)
                    {
                        case TemperatureUnits.Celcius:
                            return KelvinToCelcius();
                        case TemperatureUnits.Fahrenheit:
                            return KelvinToFahrenheit();
                        case TemperatureUnits.Kelvin:
                            return Temperature;
                        default:
                            return -1;
                    }
                default:
                    return -1;
            }
        }
    }
}
