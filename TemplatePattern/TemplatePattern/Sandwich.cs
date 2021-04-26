using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class Sandwich
    {
        public string bread = "bread", meat = "meat", cheese = "cheese";
        public List<string> toppings;
        public List<string> condiments;
        public bool hotCheese = false, stay = false;


        public void prepareRecipe(string bread, string meat, string cheese, List<string> toppings, List<string> condiments, bool meltedCheese, bool stay)
        {
            assembleBMC(bread, meat, cheese);
            if (meltedCheese)
            {
                customerWantsHotCheese();
            }
            cook();
            addToppings(toppings);
            addCondiments(condiments);
            bagTray(stay);
        }

        public void assembleBMC(string bread, string meat, string cheese)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;

            Console.WriteLine("Getting " + bread);
            Console.WriteLine("Getting " + meat);
            Console.WriteLine("Getting " + cheese);
        }

        public abstract void cook();

        public abstract void addToppings(List<string> toppings);

        public abstract void addCondiments(List<string> condiments);

        public void bagTray(bool stay)
        {
            this.stay = stay;

            if (this.stay)
            {
                Console.WriteLine("Putting food on a tray...");
            }
            else
            {
                Console.WriteLine("Bagging food now...");
            }
        }

        public abstract void customerWantsHotCheese();
    }
}
