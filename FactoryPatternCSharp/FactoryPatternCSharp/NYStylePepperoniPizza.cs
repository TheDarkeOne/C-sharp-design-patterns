using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Thin crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Red Peppers");
            toppings.Add("Pepperoni");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }
    }
}
