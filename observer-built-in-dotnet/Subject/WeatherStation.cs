using System;
using System.Collections.Generic;
using System.Linq;

namespace observer.Subject
{
    public class WeatherStation : IObservable<Measurement>
    {
        private List<IObserver<Measurement>> subscribers;

        public WeatherStation()
        {
            subscribers = new List<IObserver<Measurement>>();
        }

        public IDisposable Subscribe(IObserver<Measurement> subscriber)
        {
            if(subscriber != null && !subscribers.Contains(subscriber))
            {
                subscribers.Add(subscriber);
            }

            return new Unsibscriber(subscribers, subscriber);
        }

        public void MeasurementsChanged(double t, double p, double h)
        {
            if(subscribers.Count == 0)
            {
                System.Console.WriteLine("There are no subscribers to notify.");
                return;
            }

            Notify(new Measurement(t, h, p));
        }

        public void MeasurementStopped()
        {
            foreach(var subscriber in subscribers.ToArray())
            {
                subscriber.OnCompleted();
            }
            
            subscribers.Clear();
        }

        private void Notify(Measurement value)
        {
            foreach(var subscriber in subscribers)
            {
                subscriber.OnNext(value);
            }
        }

        private class Unsibscriber : IDisposable
        {
            private List<IObserver<Measurement>> subscribers;
            private IObserver<Measurement> subscriber;

            public Unsibscriber(List<IObserver<Measurement>> subscribers, IObserver<Measurement> subscriber)
            {
                this.subscriber = subscriber;
                this.subscribers = subscribers;
            }

            public void Dispose()
            {
                if(subscriber != null && subscribers.Contains(subscriber))
                {
                    subscribers.Remove(subscriber);
                }
            }
        }
    }
}