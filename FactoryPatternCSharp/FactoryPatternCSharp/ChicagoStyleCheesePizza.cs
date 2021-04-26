using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Parmesan Cheese");
            toppings.Add("Oregano");
        }

    
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
