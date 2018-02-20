using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Observer : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;
        private MainWindow _window;

        public Observer(ISubject weatherData, MainWindow window)
        {
            _weatherData = weatherData;
            _window = window;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            _window.SetObserverLabel(_temperature, _humidity, _pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
