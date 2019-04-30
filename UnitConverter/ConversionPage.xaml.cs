using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnitConverter
{
    /// <summary>
    /// Interaction logic for ConversionPage.xaml
    /// </summary>
    public partial class ConversionPage : Page
    {
        public ConversionPage()
        {
            InitializeComponent();
        }

        public ConversionPage(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            
            InputValidation validation = new InputValidation(valueToConvert.Text.ToString(), ExceptionAction);

            if (validation.ValidateInput())
            {
                double result = 0;

                double value = double.Parse(valueToConvert.Text.ToString());

                if (DataContext.ToString() == "UnitConverter.TemperatureConverter")
                {
                    Temperature(result, value);
                }
                else if (DataContext.ToString() == "UnitConverter.LengthConverter")
                {
                    Length(result, value);
                }
                else if (DataContext.ToString() == "UnitConverter.WeightConverter")
                {
                    Weight(result, value);
                }
            }
        }

        public void Weight(double result, double value)
        {
            if (fromUnit.SelectedItem.ToString() == "Килограм")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Паунд":
                        result = WeightConverter.KgToPound(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Унция":
                        result = WeightConverter.KgToOunces(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
            else if (fromUnit.SelectedItem.ToString() == "Паунд")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Килограм":
                        result = WeightConverter.PoundToKg(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Унция":
                        result = WeightConverter.PoundToOunces(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
            else if (fromUnit.SelectedItem.ToString() == "Унция")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Килограм":
                        result = WeightConverter.OuncesToKg(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Паунд":
                        result = WeightConverter.OuncesToPound(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
        }

        public void Length(double result, double value)
        {
            if (fromUnit.SelectedItem.ToString() == "Метри")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Фут":
                        result = LengthConverter.MetersToFeet(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Мили":
                        result = LengthConverter.MetersToMiles(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
            else if (fromUnit.SelectedItem.ToString() == "Фут")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Метри":
                        result = LengthConverter.FeetToMeters(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Мили":
                        result = LengthConverter.FeetToMiles(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
            else if (fromUnit.SelectedItem.ToString() == "Мили")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Метри":
                        result = LengthConverter.MilesToMeters(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Фут":
                        result = LengthConverter.MilesToFeet(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
        }

        public void Temperature(double result, double value)
        {
            if (fromUnit.SelectedItem.ToString() == "Целзий")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Фаренхайт":
                        result = TemperatureConverter.CelsiusToFahrenheit(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Келвин":
                        result = TemperatureConverter.CelsiusToKelvin(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
            else if (fromUnit.SelectedItem.ToString() == "Фаренхайт")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Целзий":
                        result = TemperatureConverter.FahrenheitToCelsius(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Келвин":
                        result = TemperatureConverter.FahrenheitToKelvin(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
            else if (fromUnit.SelectedItem.ToString() == "Келвин")
            {
                switch (toUnit.SelectedItem.ToString())
                {
                    case "Целзий":
                        result = TemperatureConverter.KelvinToCelsius(value);

                        resultValue.Text = result.ToString();
                        break;
                    case "Фаренхайт":
                        result = TemperatureConverter.KelvinToFahrenheit(value);

                        resultValue.Text = result.ToString();
                        break;
                }
            }
        }

        public static void ExceptionAction(string s)
        {
            MessageBox.Show(s, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            //Console.WriteLine("Oops! " + s);
        }
    }
}
