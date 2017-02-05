using System;

namespace observer_with_events
{
    public class Observable
    {
        private int _value;
        private EventHandler ValueChanged;

        public int Value
        {
            get { return _value; }
            set 
            {
                if(_value != value)
                {
                    _value = value;
                    if(ValueChanged != null)
                    {
                        ValueChanged(this, EventArgs.Empty);
                    }
                }

            }
        }

        public void Subscribe(EventHandler handler)
        {
            ValueChanged += handler;
        }

        public void Unsubscribe(EventHandler handler)
        {
            ValueChanged -= handler;
        }
    }
}