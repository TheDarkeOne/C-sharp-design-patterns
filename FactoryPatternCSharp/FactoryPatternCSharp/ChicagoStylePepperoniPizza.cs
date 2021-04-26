using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Thick crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Grated Mozzarella Cheese");
            toppings.Add("Parmesan Cheese");
            toppings.Add("Eggplant");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Pepperoni");
        }

    
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
