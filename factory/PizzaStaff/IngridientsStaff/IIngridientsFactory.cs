namespace factory.PizzaStaff.IngridientsStaff
{
    public interface IIngridientsFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IMeet CreateMeet();
        ISauce CreateSause();
    }
}