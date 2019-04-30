using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class WeightConverter
    {
        public ObservableCollection<string> units;

        public ObservableCollection<string> Units
        {
            get
            {
                return units;
            }
        }

        public WeightConverter()
        {
            units = new ObservableCollection<string>();
            AddUnits();
        }

        public void AddUnits()
        {
            units.Add("Килограм");
            units.Add("Паунд");
            units.Add("Унция");
        }

        public static double KgToPound(double value)
        {
            double result = value * 2.20462262185;

            return result;
        }

        public static double KgToOunces(double value)
        {
            double result = value * 35.27396195;

            return result;
        }

        public static double PoundToKg(double value)
        {
            double result = value * 0.45359237;

            return result;
        }

        public static double PoundToOunces(double value)
        {
            double result = value * 16;

            return result;
        }

        public static double OuncesToKg(double value)
        {
            double result = value * 0.0283495231;

            return result;
        }

        public static double OuncesToPound(double value)
        {
            double result = value * 0.0625;

            return result;
        }
    }
}
