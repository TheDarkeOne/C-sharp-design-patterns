using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Garlic");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }
    }
}
