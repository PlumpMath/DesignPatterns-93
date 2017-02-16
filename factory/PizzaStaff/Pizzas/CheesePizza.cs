using System;
using factory.PizzaStaff.IngridientsStaff;

namespace factory.PizzaStaff.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IIngridientsFactory ingridientsFactory;

        public CheesePizza(IIngridientsFactory factory)
        {
            ingridientsFactory = factory;
        }
        public override void Prepare()
        {
            System.Console.WriteLine($"Preparing `{GetName()}` pizza. More cheese please!");
            dough = ingridientsFactory.CreateDough();
            cheese = ingridientsFactory.CreateCheese();
            sauce = ingridientsFactory.CreateSause();
        }
    }
}