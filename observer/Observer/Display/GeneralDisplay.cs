using observer.Subject;

namespace observer.Observer.Display
{
    public class GeneralDisplay : IDisplayElement, IObserver
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private ISubject weatherSource;

        public GeneralDisplay(ISubject weatherSource)
        {
            this.weatherSource = weatherSource;
            weatherSource.Subscribe(this);
        }

        public void Display()
        {
            string info = $"Current weather conditions: {temperature}°C, {pressure}mm, {humidity}%";
            System.Console.WriteLine(info);
        }

        public void Update(double t, double p, double h)
        {
            this.temperature = t;
            this.pressure = p;
            this.humidity = h;
            Display();
        }
    }
}