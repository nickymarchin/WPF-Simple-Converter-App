using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class TemperatureConverter
    {
        public ObservableCollection<string> units;

        public ObservableCollection<string> Units
        {
            get
            {
                return units;
            }
        }

        public TemperatureConverter()
        {
            units = new ObservableCollection<string>();
            AddUnits();
        }

        public void AddUnits()
        {
            units.Add("Целзий");
            units.Add("Фаренхайт");
            units.Add("Келвин");
        }

        public static double CelsiusToFahrenheit(double value)
        {
            double result = value * (9.0 / 5) + 32;

            return result;
        }

        public static double CelsiusToKelvin(double value)
        {
            double result = value + 273.15;

            return result;
        }

        public static double FahrenheitToCelsius(double value)
        {
            double result = (value - 32) * (5.0 / 9);

            return result;
        }

        public static double FahrenheitToKelvin(double value)
        {
            double result = (value + 459.67) * (5.0 / 9);

            return result;
        }

        public static double KelvinToCelsius(double value)
        {
            double result = value - 273.15;

            return result;
        }

        public static double KelvinToFahrenheit(double value)
        {
            double result = value * (9.0 / 5) - 459.67;

            return result;
        }
    }
}
