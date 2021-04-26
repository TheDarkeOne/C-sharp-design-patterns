using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class subSandwich : Sandwich
    {
        public subSandwich()
        {

        }

        public subSandwich(string bread, string meat, string cheese, List<string> toppings, List<string> condiments, bool stay)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.stay = stay;
            this.toppings = new List<string>(toppings);
            this.condiments = new List<string>(condiments);
        }

        public override void cook()
        {
            Console.WriteLine("Toasting bread for 2 minutes");
        }

        public override void addToppings(List<string> toppings)
        {
            this.toppings = toppings;

            for (int x = 0; x < toppings.Count; x++)
            {
                Console.WriteLine("Adding " + toppings[x] + " to the Sub");
            }

        }

        public override void addCondiments(List<string> condiments)
        {
            this.condiments = condiments;

            for (int x = 0; x < condiments.Count; x++)
            {
                Console.WriteLine("Adding " + condiments[x] + " to the Sub");
            }

        }

        public override void customerWantsHotCheese()
        {
            hotCheese = false;
        }
    }
}
