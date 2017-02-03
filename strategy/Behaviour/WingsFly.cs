using System;

namespace initial.Behaviour
{
    public class WingsFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Spread your wings! Let's fly!");
        }
    }
}