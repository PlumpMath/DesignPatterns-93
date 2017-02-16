using factory.PizzaStaff.IngridientsStaff;

namespace factory.PizzaStaff.Pizzas
{
    public class MeetPizza : Pizza
    {
        private readonly IIngridientsFactory ingridientsFactory;

        public MeetPizza(IIngridientsFactory factory)
        {
            ingridientsFactory = factory;
        }

        public override void Prepare()
        {
            System.Console.WriteLine($"Preparing `{GetName()} pizza. More meet, no cheese!`");
            dough = ingridientsFactory.CreateDough();
            meet = ingridientsFactory.CreateMeet();
            sauce = ingridientsFactory.CreateSause();
        }
    }
}