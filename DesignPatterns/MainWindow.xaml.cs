using Observer;
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

namespace DesignPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherData _weatherData;
        private Observer _observer;

        public MainWindow()
        {
            _weatherData = new WeatherData();
            _observer = new Observer(_weatherData, this);
            InitializeComponent();
            _weatherData.SetMeasurements(15.5f, 70f, 20f);
        }

        private void observerButton_Click(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            _weatherData.SetMeasurements(random.Next(0, 30), random.Next(50, 100), random.Next(0, 100));
        }

        public void SetObserverLabel(float temp, float humidity, float pressure)
        {
            observerLabel.Content = $"Temperature: {temp}; Humidity: {humidity}; Pressure: {pressure};";
        }
    }
}
