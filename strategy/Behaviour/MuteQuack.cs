using System;

namespace initial.Behaviour
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine(".....silence");
        }
    }
}