namespace observer.Observer
{
    public interface IObserver
    {
         void Update(double temperature, double presure, double humidity);
    }
}