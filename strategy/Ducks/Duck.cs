using initial.Behaviour;

namespace initial.Ducks
{
    public abstract class Duck
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void SetFlyBehaviour(IFlyable flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }

        public abstract void Display();
        public void Swim()
        {
            System.Console.WriteLine("Swimming time!");
        }
    }
}