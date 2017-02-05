using System;
using observer.Display;

namespace observer.Observer.Display
{
    public class GeneralDisplay : IDisplayElement, IObserver<Measurement>
    {
        private string displayName;
        private IDisposable unsubscriber;

        public GeneralDisplay(string Name, IObservable<Measurement> provider)
        {
            displayName = Name;
            Subscribe(provider);
        }

        public void Subscribe(IObservable<Measurement> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public void Display(Measurement value)
        {
            string info = $"{displayName} current weather conditions: {value.Temperature}°C, {value.Pressure}mm, {value.Humidity}%";
            System.Console.WriteLine(info);
        }

        public void OnCompleted()
        {
            System.Console.WriteLine($"{displayName} no longer receives measurements. Subscription has stopped.");
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            System.Console.WriteLine($"{displayName} measurements cannot be shown.");
        }

        public void OnNext(Measurement value)
        {
            Display(value);
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}