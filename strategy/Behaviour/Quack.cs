using System;

namespace initial.Behaviour
{
    public class SimpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quaaaaaack!");
        }
    }
}