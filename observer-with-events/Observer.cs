using System;

namespace observer_with_events
{

    public class Observer
    {
        protected string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Subscribe(Observable provider)
        {
            provider.Subscribe(HandleEvent);
        }

        public void Unsubscribe(Observable provider)
        {
            provider.Unsubscribe(HandleEvent);
        }

        public void HandleEvent(object sender, EventArgs args)
        {
            int value = ((Observable)sender).Value;
            System.Console.WriteLine($"{_name} detected that value changed to {value}");
        }
    }
}