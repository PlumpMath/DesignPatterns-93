using factory.PizzaStaff.IngridientsStaff.Ingridients;

namespace factory.PizzaStaff.IngridientsStaff.ConcreteFactories
{
    public class ChicagoIngridientsFactory : IIngridientsFactory
    {
        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public IDough CreateDough()
        {
            return new ThinDough();
        }

        public IMeet CreateMeet()
        {
            return new Chicken();
        }

        public ISauce CreateSause()
        {
            return new MildSauce();
        }
    }
}