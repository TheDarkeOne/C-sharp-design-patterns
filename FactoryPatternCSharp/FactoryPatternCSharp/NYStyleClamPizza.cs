using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Thin crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }
    }
}
