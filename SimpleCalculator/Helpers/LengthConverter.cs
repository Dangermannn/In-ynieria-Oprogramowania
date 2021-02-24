using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Helpers
{
    public class LengthConverter
    {
        double Length;

        public double MilimetersToCentimeters() => Length * 0.1;

        public double MilimetersToMeters() => Length * 0.001;
        public double MilimetersToKilometers() => Length * 0.000001;

        public double CentimetersToMilimeters() => Length * 10.0;
        public double CentimetersToMeters() => Length * 0.01;
        public double CentimetersToKilometers() => Length * 0.00001;

        public double MetersToMilimeters() => Length * 1000.0;
        public double MetersToCentimeters() => Length * 100.0;
        public double MetersToKilometers() => Length * 0.001;

        public double KilometersToMilimeters() => Length * 1000000;
        public double KilometersToCentimeters() => Length * 100000;
        public double KilometersToMeters() => Length * 1000;

        public void SetLength(double len) => Length = len;

        public double HandleConverter(string unitFrom, string unitTo)
        {
            switch (unitFrom)
            {
                case LengthUnits.Milimeters:
                    switch (unitTo)
                    {
                        case LengthUnits.Milimeters:
                            return Length;
                        case LengthUnits.Centimeters:
                            return MilimetersToCentimeters();
                        case LengthUnits.Meters:
                            return MilimetersToMeters();
                        case LengthUnits.Kilometers:
                            return MilimetersToKilometers();
                        default:
                            return -1;
                    }
                case LengthUnits.Centimeters:
                    switch (unitTo)
                    {
                        case LengthUnits.Milimeters:
                            return CentimetersToMilimeters();
                        case LengthUnits.Centimeters:
                            return Length;
                        case LengthUnits.Meters:
                            return CentimetersToMeters();
                        case LengthUnits.Kilometers:
                            return CentimetersToKilometers();
                        default:
                            return -1;
                    }
                case LengthUnits.Meters:
                    switch (unitTo)
                    {
                        case LengthUnits.Milimeters:
                            return MetersToMilimeters();
                        case LengthUnits.Centimeters:
                            return MetersToCentimeters();
                        case LengthUnits.Meters:
                            return Length;
                        case LengthUnits.Kilometers:
                            return MetersToKilometers();
                        default:
                            return -1;
                    }
                case LengthUnits.Kilometers:
                    switch (unitTo)
                    {
                        case LengthUnits.Milimeters:
                            return KilometersToMilimeters();
                        case LengthUnits.Centimeters:
                            return KilometersToCentimeters();
                        case LengthUnits.Meters:
                            return KilometersToMeters();
                        case LengthUnits.Kilometers:
                            return Length;
                        default:
                            return -1;
                    }
                default:
                    return -1;
            }
        }
    }
}
