using observer.Observer;

namespace observer.Subject
{
    public interface ISubject
    {
         void Subscribe(IObserver subscriber);
         void Unsubscribe(IObserver subscriber);
         void Notify();
    }
}