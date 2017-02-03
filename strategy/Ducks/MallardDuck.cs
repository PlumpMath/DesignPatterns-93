using initial.Behaviour;

namespace initial.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new WingsFly();
            quackBehaviour = new SimpleQuack();
        }
        public override void Display()
        {
            System.Console.WriteLine("I'm a real mallard duck");
        }
    }
}