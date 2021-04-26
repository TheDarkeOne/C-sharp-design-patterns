using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            dough = "Thin crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Red Peppers");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }
    }
}
