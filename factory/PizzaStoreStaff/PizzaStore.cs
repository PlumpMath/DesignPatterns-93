using factory.PizzaStaff;

namespace factory.PizzaStoreStaff
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string order)
        {
            var pizza = CreatePizza(order);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }
        protected abstract Pizza CreatePizza(string order);
    }
}