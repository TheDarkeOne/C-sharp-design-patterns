using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            dough = "Thick crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Grated Mozzarella Cheese");
            toppings.Add("Parmesan Cheese");
            toppings.Add("Eggplant");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
        }

    
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
