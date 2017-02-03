using System;

namespace initial.Behaviour
{
    public class RocketFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Rocket fly!");
        }
    }
}