using System.Collections.Generic;
using observer.Observer;

namespace observer.Subject
{
    public class WeatherStation : ISubject
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private List<IObserver> subscribers;

        public WeatherStation()
        {
            subscribers = new List<IObserver>();
        }

        public void Notify()
        {
            if(subscribers.Count == 0)
                System.Console.WriteLine("Nothing to notify.");

            foreach(var subscriber in subscribers)
            {
                subscriber.Update(this.temperature, this.pressure, this.humidity);
            }
        }

        public void Subscribe(IObserver subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(IObserver subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void MeasurementsChanged(double t, double p, double h)
        {
            this.temperature = t;
            this.pressure = p;
            this.humidity = h;
            Notify();
        }
    }
}