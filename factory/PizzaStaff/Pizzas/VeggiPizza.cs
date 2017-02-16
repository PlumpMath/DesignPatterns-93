using factory.PizzaStaff.IngridientsStaff;

namespace factory.PizzaStaff.Pizzas
{
    public class VeggiPizza : Pizza
    {
        private readonly IIngridientsFactory ingridientsFactory;
        public VeggiPizza(IIngridientsFactory factory)
        {
            ingridientsFactory = factory;
        }

        public override void Prepare()
        {
            System.Console.WriteLine($"Preparing `{GetName()}` pizza. No meet please!");
            dough = ingridientsFactory.CreateDough();
            cheese = ingridientsFactory.CreateCheese();
            sauce = ingridientsFactory.CreateSause();
        }
    }
}