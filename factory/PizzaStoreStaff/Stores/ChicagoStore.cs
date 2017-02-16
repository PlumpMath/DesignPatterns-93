using factory.PizzaStaff;
using factory.PizzaStaff.IngridientsStaff;
using factory.PizzaStaff.IngridientsStaff.ConcreteFactories;
using factory.PizzaStaff.Pizzas;

namespace factory.PizzaStoreStaff.Stores
{
    public class ChicagoStore : PizzaStore
    {
        Pizza pizza = null;
        IIngridientsFactory ingridientsFactory = new ChicagoIngridientsFactory();
        
        protected override Pizza CreatePizza(string order)
        {
            switch(order)
            {
                case "Cheese": 
                {
                    pizza = new CheesePizza(ingridientsFactory);
                    pizza.SetName("Chicago Cheese pizza");
                    break;
                }
                case "Meet":
                {
                    pizza = new MeetPizza(ingridientsFactory);
                    pizza.SetName("Chicago Meet pizza");
                    break;
                }
                case "Veggie":
                {
                    pizza = new VeggiPizza(ingridientsFactory);
                    pizza.SetName("Chicago Veggie pizza");
                    break;
                }
            }

            pizza.Prepare();

            return pizza;
        }
    }
}