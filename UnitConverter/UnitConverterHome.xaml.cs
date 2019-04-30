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
    /// Interaction logic for UnitConverterHome.xaml
    /// </summary>
    public partial class UnitConverterHome : Page
    {
        public UnitConverterHome()
        {
            InitializeComponent();
        }

        private void homeForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (unitComboBox.Text == "Температура")
            {
                TemperatureConverter temperature = new TemperatureConverter();

                ConversionPage conversionPage = new ConversionPage(temperature);

                this.NavigationService.Navigate(conversionPage);
            }
            else if (unitComboBox.Text == "Дължина")
            {
                LengthConverter length = new LengthConverter();

                ConversionPage conversionPage = new ConversionPage(length);

                this.NavigationService.Navigate(conversionPage);
            }
            else if (unitComboBox.Text == "Маса")
            {
                WeightConverter weight = new WeightConverter();

                ConversionPage conversionPage = new ConversionPage(weight);

                this.NavigationService.Navigate(conversionPage);
            }
            else
            {
                MessageBox.Show("Моля изберете величина!", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
        }
    }
}
