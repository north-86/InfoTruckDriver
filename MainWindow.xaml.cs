using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace InfoTruckDriver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResetClick(object sender, RoutedEventArgs e)
        {
            textboxCelsius.Text = null;
            textboxFahrenheit.Text = null;
            textblockCelsius.Text = null;
            textblockFahrenheit.Text = null;

            textboxMile.Text = null;
            textboxKilometer.Text = null;
            textblockMile.Text = null;
            textblockKilometer.Text = null;

            textboxPound.Text = null;
            textboxKg.Text = null;
            textblockPound.Text = null;
            textblockKg.Text = null;

            textboxFoot.Text = null;
            textboxMeter.Text = null;
            textblockFoot.Text = null;
            textblockMeter.Text = null;

            textboxGallon.Text = null;
            textboxLiter.Text = null;
            textblockGallon.Text = null;
            textblockLiter.Text = null;

            textboxMPG.Text = null;
            textboxL100km.Text = null;
            textblockMPG.Text = null;
            textblockL100km.Text = null;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HyperlinkClick(object sender, RoutedEventArgs e)
        {
            var url = "https://www.transportation.gov/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void ToFahrenheitClick(object sender, RoutedEventArgs e)
        {
            decimal celsius = Convert.ToDecimal(textboxCelsius.Text);
            if (celsius >= -70 && celsius <= 60)
            {
                decimal fahrenheit = (celsius * 9 / 5) + 32;
                textblockFahrenheit.Text = fahrenheit.ToString();
            }
            else
            {
                textboxCelsius.Text = "Error";
                textblockFahrenheit.Text = null;
            }
        }

        private void ToCelsiusClick(object sender, RoutedEventArgs e)
        {
            decimal fahrenheit = Convert.ToDecimal(textboxFahrenheit.Text);
            if(fahrenheit >= -94 && fahrenheit <= 140)
            {
                decimal celsius = (fahrenheit - 32) * 5 / 9;
                textblockCelsius.Text = celsius.ToString();
            }
            else
            {
                textboxFahrenheit.Text = "Error";
                textblockCelsius.Text = null;
            }
        }

        private void ToKilometerClick(object sender, RoutedEventArgs e)
        {
            decimal mile = Convert.ToDecimal(textboxMile.Text);
            if (mile >= 0)
            {
                decimal kilometer = mile * 1.609m;
                textblockKilometer.Text = kilometer.ToString();
            }
            else
            {
                textboxMile.Text = "Error";
                textblockKilometer.Text = null;
            }
        }

        private void ToMileClick(object sender, RoutedEventArgs e)
        {
            decimal kilometer = Convert.ToDecimal(textboxKilometer.Text);
            if (kilometer >= 0)
            {
                decimal mile = kilometer / 1.609m;
                textblockMile.Text = mile.ToString();
            }
            else
            {
                textboxKilometer.Text = "Error";
                textblockMile.Text = null;
            }
        }

        private void ToLiterClick(object sender, RoutedEventArgs e)
        {
            decimal gallon = Convert.ToDecimal(textboxGallon.Text);
            if (gallon >= 0)
            {
                decimal liter = gallon * 3.785m;
                textblockLiter.Text = liter.ToString();
            }
            else
            {
                textboxGallon.Text = "Error";
                textblockLiter.Text = null;
            }
        }

        private void ToGallonClick(object sender, RoutedEventArgs e)
        {
            decimal liter = Convert.ToDecimal(textboxLiter.Text);
            if (liter >= 0)
            {
                decimal gallon = liter / 3.785m;
                textblockGallon.Text = gallon.ToString();
            }
            else
            {
                textboxLiter.Text = "Error";
                textblockGallon.Text = null;
            }
        }

        private void ToLiter100Click(object sender, RoutedEventArgs e)
        {
            decimal mpg = Convert.ToDecimal(textboxMPG.Text);
            if (mpg >= 0)
            {
                decimal l100km = 235.215m / mpg;
                textblockL100km.Text = l100km.ToString();
            }
            else
            {
                textboxMPG.Text = "Error";
                textblockL100km.Text = null;
            }
        }

        private void ToMPGClick(object sender, RoutedEventArgs e)
        {
            decimal l100km = Convert.ToDecimal(textboxL100km.Text);
            if (l100km >= 0)
            {
                decimal mpg = 235.215m / l100km;
                textblockMPG.Text = mpg.ToString();
            }
            else
            {
                textboxL100km.Text = "Error";
                textblockMPG.Text = null;
            }
        }

        private void ToKgClick(object sender, RoutedEventArgs e)
        {
            decimal pound = Convert.ToDecimal(textboxPound.Text);
            if (pound >= 0)
            {
                decimal kg = pound * 0.4536m;
                textblockKg.Text = kg.ToString();
            }
            else
            {
                textboxPound.Text = "Error";
                textblockKg.Text = null;
            }
        }

        private void ToPoundClick(object sender, RoutedEventArgs e)
        {
            decimal kg = Convert.ToDecimal(textboxKg.Text);
            if (kg >= 0)
            {
                decimal pound = kg / 0.4536m;
                textblockPound.Text = pound.ToString();
            }
            else
            {
                textboxKg.Text = "Error";
                textblockPound.Text = null;
            }
        }

        private void ToMeterClick(object sender, RoutedEventArgs e)
        {
            decimal foot = Convert.ToDecimal(textboxFoot.Text);
            if (foot >= 0)
            {
                decimal meter = foot * 0.3048m;
                textblockMeter.Text = meter.ToString();
            }
            else
            {
                textboxFoot.Text = "Error";
                textblockMeter.Text = null;
            }
        }

        private void ToFootClick(object sender, RoutedEventArgs e)
        {
            decimal meter = Convert.ToDecimal(textboxMeter.Text);
            if (meter >= 0)
            {
                decimal foot = meter / 0.3048m;
                textblockFoot.Text = foot.ToString();
            }
            else
            {
                textboxMeter.Text = "Error";
                textblockFoot.Text = null;
            }
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal, (object s, EventArgs ev) =>
            {
                this.currentTime.Text = "Current Time: " + DateTime.Now.ToString("hh:mm:ss");
                this.currentDate.Text = "Current Date: " + DateTime.Now.ToString("dd/MM/yyyy");
            }, this.Dispatcher);
            timer.Start();
        }
    }
}
