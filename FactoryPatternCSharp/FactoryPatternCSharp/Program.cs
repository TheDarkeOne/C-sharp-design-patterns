using System;

namespace FactoryPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");
        }
    }
}
