using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in toppings)
            {
                Console.WriteLine("  " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degrees");

        }

        public abstract void Cut();

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }
    }
}
