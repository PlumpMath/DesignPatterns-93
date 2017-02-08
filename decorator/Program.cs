using System;
using decorator;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var capuchino = new Capuchino();
            var capuchinoWithChocolate = new Chocolate(capuchino);
            var capuchinoWithDoubleChocolate = new Chocolate(capuchinoWithChocolate);
            var capuchinoWithDoubleChocolateAndCinnamon = new Cinnamon(capuchinoWithDoubleChocolate);
            
            Console.WriteLine(
                $"{capuchinoWithDoubleChocolateAndCinnamon.GetDescription().Trim()}: {capuchinoWithDoubleChocolateAndCinnamon.GetCost()}$"
            );
        }
    }
}
