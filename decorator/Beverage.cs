namespace decorator
{
    public abstract class Beverage
    {
        protected string description;
        protected CupSize size;
        
        public Beverage(CupSize size)
        {
            this.size = size;
        }
        
        public CupSize GetSize()
        {
            return size;
        }

        public abstract string GetDescription();
        public abstract double GetCost();
    }

    public class Capuchino : Beverage
    {
        public Capuchino(CupSize size) : base(size)
        { }

        public override string GetDescription()
        {
            return "Capuchino";
        }
        public override double GetCost()
        {
            return 1.5 * (int)base.GetSize();
        }
    }

    public class Americano : Beverage
    {
        public Americano(CupSize size) : base(size)
        { }
        
        public override string GetDescription()
        {
            return "Americano";
        }
        public override double GetCost()
        {
            return 1 * (int)base.GetSize();
        }
    }

    public class Espresso : Beverage
    {
        public Espresso(CupSize size) : base(size)
        { }
        public override string GetDescription()
        {
            return "Espresso";
        }
        public override double GetCost()
        {
            return 0.8 * (int)base.GetSize();
        }
    }
}