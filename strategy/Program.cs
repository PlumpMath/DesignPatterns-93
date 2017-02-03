using initial.Behaviour;
using initial.Ducks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            mallardDuck.SetFlyBehaviour(new RocketFly());
            mallardDuck.PerformFly();
        }
    }
}
