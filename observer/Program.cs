using observer.Observer;
using observer.Observer.Display;
using observer.Subject;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            GeneralDisplay subscriber1 = new GeneralDisplay(weatherStation);
            weatherStation.MeasurementsChanged(20, 770, 50);
         
            ForecastDisplay subscriber2 = new ForecastDisplay(weatherStation);
            weatherStation.MeasurementsChanged(18, 769, 54);
         
            weatherStation.Unsubscribe(subscriber2);
            weatherStation.MeasurementsChanged(15, 750, 78);

            weatherStation.Unsubscribe(subscriber1);
            weatherStation.MeasurementsChanged(14, 745, 90);

            weatherStation.Subscribe(subscriber1);
            weatherStation.MeasurementsChanged(13, 740, 99);
        }
    }
}
