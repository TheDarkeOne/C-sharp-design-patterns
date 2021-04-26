using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCSharp
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else if (item.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (item.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else return null;

        }
    }
}
