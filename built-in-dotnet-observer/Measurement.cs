namespace observer
{
    public class Measurement
    {
        private double temperature;
        private double humidity;
        private double pressure;

        public Measurement(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public double Temperature { get {return temperature;} }
        public double Humidity { get {return humidity;}  }
        public double Pressure { get {return pressure;}  }
    }
}