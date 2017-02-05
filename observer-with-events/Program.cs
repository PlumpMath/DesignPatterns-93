using observer_with_events;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Observable provider = new Observable();
            
            Observer observer1 = new Observer("Observer 1");
            observer1.Subscribe(provider);
            
            Observer observer2 = new Observer("Observer 2");
            observer2.Subscribe(provider);

            provider.Value = 12;

            observer1.Unsubscribe(provider);

            provider.Value = 10;
        }
        //Observer 1 detected that value changed to 12
        //Observer 2 detected that value changed to 12
        //Observer 2 detected that value changed to 10

    }
}
