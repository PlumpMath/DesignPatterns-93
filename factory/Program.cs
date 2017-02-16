using factory.PizzaStaff;
using factory.PizzaStoreStaff;
using factory.PizzaStoreStaff.Stores;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYStore();
            Pizza pizza = pizzaStore.OrderPizza("Cheese");

            pizzaStore = new ChicagoStore();
            pizza = pizzaStore.OrderPizza("Meet");
        }
    }
}
