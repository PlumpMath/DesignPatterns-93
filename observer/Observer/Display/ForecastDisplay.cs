using System;
using observer.Subject;

namespace observer.Observer.Display
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private ISubject weatherSource;
        public ForecastDisplay(ISubject weatherData)
        {
            weatherSource = weatherData;
            weatherSource.Subscribe(this);
        }

        public void Display()
        {
            System.Console.WriteLine("Watch out for cooler. Rainy weather!");
        }

        public void Update(double temperature, double presure, double humidity)
        {
            Display();
        }
    }
}