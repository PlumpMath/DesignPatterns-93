using factory.PizzaStaff.IngridientsStaff;

namespace factory.PizzaStaff
{
    public abstract class Pizza
    {
        private string name;
        protected IDough dough;
        protected ICheese cheese;
        protected IMeet meet;
        protected ISauce sauce;

        public void Bake()
        {
            System.Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            System.Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            System.Console.WriteLine("Place pizza in official box");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        
        public abstract void Prepare();
    }
}