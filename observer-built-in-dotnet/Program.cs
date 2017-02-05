using observer.Observer.Display;
using observer.Subject;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            GeneralDisplay subscriber1 = new GeneralDisplay("Display 1", weatherStation);
            weatherStation.MeasurementsChanged(20, 770, 50);

            GeneralDisplay subscriber2 = new GeneralDisplay("Display 2", weatherStation);
            weatherStation.MeasurementsChanged(18, 769, 54);
         
            subscriber1.Unsubscribe();
            weatherStation.MeasurementsChanged(15, 750, 78);

            subscriber2.Unsubscribe();
            weatherStation.MeasurementsChanged(14, 745, 90);

            subscriber1.Subscribe(weatherStation);
            subscriber2.Subscribe(weatherStation);
            weatherStation.MeasurementsChanged(13, 740, 99);

            weatherStation.MeasurementStopped();
        }
    }
}
