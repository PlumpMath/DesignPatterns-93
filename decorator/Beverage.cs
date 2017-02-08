namespace decorator
{
    public abstract class Beverage
    {
        protected string description;
        public abstract string GetDescription();
        public abstract double GetCost();
    }

    public class Capuchino : Beverage
    {
        public override string GetDescription()
        {
            return "Capuchino";
        }
        public override double GetCost()
        {
            return 1.5;
        }
    }

    public class Americano : Beverage
    {
        public override string GetDescription()
        {
            return "Americano";
        }
        public override double GetCost()
        {
            return 1;
        }
    }

    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }
        public override double GetCost()
        {
            return 0.8;
        }
    }
}