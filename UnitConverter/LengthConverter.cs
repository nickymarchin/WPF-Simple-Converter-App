using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class LengthConverter
    {
        public ObservableCollection<string> units;

        public ObservableCollection<string> Units
        {
            get
            {
                return units;
            }
        }

        public LengthConverter()
        {
            units = new ObservableCollection<string>();
            AddUnits();
        }

        public void AddUnits()
        {
            units.Add("Метри");
            units.Add("Фут");
            units.Add("Мили");
        }

        public static double MetersToFeet(double value)
        {
            double result = value / 0.3048;

            return result;
        }

        public static double MetersToMiles(double value)
        {
            double result = value * 0.00062137;

            return result;
        }

        public static double FeetToMeters(double value)
        {
            double result = value / 3.2808;

            return result;
        }

        public static double FeetToMiles(double value)
        {
            double result = value * 0.00018939;

            return result;
        }

        public static double MilesToMeters(double value)
        {
            double result = value / 0.00062137;

            return result;
        }

        public static double MilesToFeet(double value)
        {
            double result = value * 5280.0;

            return result;
        }

    }
}
