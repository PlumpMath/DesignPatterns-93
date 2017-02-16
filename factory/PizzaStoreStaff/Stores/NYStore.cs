using factory.PizzaStaff;
using factory.PizzaStaff.IngridientsStaff;
using factory.PizzaStaff.IngridientsStaff.ConcreteFactories;
using factory.PizzaStaff.Pizzas;

namespace factory.PizzaStoreStaff.Stores
{
    public class NYStore : PizzaStore
    {
        Pizza pizza = null;
        IIngridientsFactory ingridientsFactory = new NYIngridientsFactory();
        protected override Pizza CreatePizza(string order)
        {
            switch(order)
            {
                case "Cheese": 
                {
                    pizza = new CheesePizza(ingridientsFactory);
                    pizza.SetName("NY Cheese pizza");
                    break;
                }
                case "Meet":
                {
                    pizza = new MeetPizza(ingridientsFactory);
                    pizza.SetName("NY Meet pizza");
                    break;
                }
                case "Veggie":
                {
                    pizza = new VeggiPizza(ingridientsFactory);
                    pizza.SetName("NY Veggie pizza");
                    break;
                }
            }

            pizza.Prepare();
            
            return pizza;
        }
    }
}