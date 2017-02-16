using factory.PizzaStaff.IngridientsStaff.Ingridients;

namespace factory.PizzaStaff.IngridientsStaff.ConcreteFactories
{
    public class NYIngridientsFactory : IIngridientsFactory
    {
        public ICheese CreateCheese()
        {
            return new Reggiano();
        }

        public IDough CreateDough()
        {
            return new ThickDough();
        }

        public IMeet CreateMeet()
        {
            return new Ham();
        }

        public ISauce CreateSause()
        {
            return new HotSauce();
        }
    }
}