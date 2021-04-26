using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Thick crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Grated Mozzarella Cheese");
            toppings.Add("Parmesan Cheese");
            toppings.Add("Frozen Clams");
        }

    
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
