using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class Burger : Sandwich
    {
        string answer = "no";
        public Burger()
        {

        }

        public Burger(string bread, string meat, string cheese, List<string> toppings, List<string> condiments, bool meltedCheese, bool stay)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            if (meltedCheese)
            {
                customerWantsHotCheese();
            }
            this.stay = stay;
            this.toppings = new List<string>(toppings);
            this.condiments = new List<string>(condiments);
        }
        public override void cook()
        {
            Console.WriteLine("Grilled " + meat + " for 10 minutes. ");

            Console.WriteLine("Toast Buns for 2 minutes. ");

            if (hotCheese)
            {
                Console.WriteLine("Melted cheese during the last minute");
            }
        }

        public override void addToppings(List<string> toppings)
        {
            this.toppings = toppings;

            for (int x = 0; x < this.toppings.Count; x++)
            {
                Console.WriteLine("Adding " + toppings[x] + " to the burger");
            }

        }

        public override void addCondiments(List<string> condiments)
        {
            this.condiments = condiments;

            for (int x = 0; x < this.condiments.Count; x++)
            {
                Console.WriteLine("Adding " + condiments[x] + " to the burger");
            }

        }

        public override void customerWantsHotCheese()
        {
            hotCheese = true;
        }

    }
}
