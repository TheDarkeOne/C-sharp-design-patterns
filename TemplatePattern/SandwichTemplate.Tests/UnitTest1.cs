using NUnit.Framework;
using System.Collections.Generic;
using TemplatePattern;

namespace SandwichTemplate.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Sub()
        {
            string bread = "Whole wheat", meat = "Turkey", cheese = "Cheddar";
            List<string> toppings = new List<string>(new string[] { "Lettuce", "Tomato", "Pickle", "Onions"});
            List<string> condiments = new List<string>(new string[] { "Mayonnaise", "Mustard"});
            bool stay = true;

            Sandwich sub1 = new subSandwich(bread, meat, cheese, toppings, condiments, stay);
            Sandwich sub2 = new subSandwich();

            sub2.prepareRecipe(bread, meat, cheese, toppings, condiments, false, stay);

            Assert.AreEqual(sub1.meat, sub2.meat);
            Assert.AreEqual(sub1.bread, sub2.bread);
            Assert.AreEqual(sub1.cheese, sub2.cheese);
            Assert.AreEqual(sub1.toppings, sub2.toppings);
            Assert.AreEqual(sub1.condiments, sub2.condiments);

        }

        [Test]
        public void burger()
        {
            string bread = "Whole wheat", meat = "Turkey", cheese = "Cheddar";
            List<string> toppings = new List<string>(new string[] { "Lettuce", "Tomato", "Pickle", "Onions" });
            List<string> condiments = new List<string>(new string[] { "Mayonnaise", "Mustard" });
            bool meltedCheese = false, stay = true;

            Sandwich burger1 = new Burger(bread, meat, cheese, toppings, condiments, meltedCheese, stay);
            Sandwich burger2 = new Burger();

            burger2.prepareRecipe(bread, meat, cheese, toppings, condiments, meltedCheese, stay);

            Assert.AreEqual(burger1.meat, burger2.meat);
            Assert.AreEqual(burger1.bread, burger2.bread);
            Assert.AreEqual(burger1.cheese, burger2.cheese);
            Assert.AreEqual(burger1.toppings, burger2.toppings);
            Assert.AreEqual(burger1.condiments, burger2.condiments);
            Assert.AreEqual(burger1.hotCheese, burger2.hotCheese);

        }

        [Test]
        public void testHook()
        {
            Sandwich burger = new Burger();

            string bread = "Whole wheat", meat = "Turkey", cheese = "Cheddar";
            List<string> toppings = new List<string>(new string[] { "Lettuce", "Tomato", "Pickle", "Onions" });
            List<string> condiments = new List<string>(new string[] { "Mayonnaise", "Mustard" });
            bool meltedCheese = true, stay = true;

            burger.prepareRecipe(bread, meat, cheese, toppings, condiments, meltedCheese, stay);

            Assert.AreEqual(true, burger.hotCheese);
        }

        [Test]
        public void testHookSub()
        {
            Sandwich sub = new subSandwich();

            string bread = "Whole wheat", meat = "Turkey", cheese = "Cheddar";
            List<string> toppings = new List<string>(new string[] { "Lettuce", "Tomato", "Pickle", "Onions"});
            List<string> condiments = new List<string>(new string[] { "Mayonnaise", "Mustard"});
            bool meltedCheese = true, stay = true;

            sub.prepareRecipe(bread, meat, cheese, toppings, condiments, meltedCheese, stay);

            Assert.AreEqual(false, sub.hotCheese);
        }

        [Test]
        public void testStay()
        {
            Sandwich burger = new Burger();

            string bread = "Whole wheat", meat = "Turkey", cheese = "Cheddar";
            List<string> toppings = new List<string>(new string[] { "Lettuce", "Tomato", "Pickle", "Onions" });
            List<string> condiments = new List<string>(new string[] { "Mayonnaise", "Mustard" });
            bool meltedCheese = true, stay = false;

            burger.prepareRecipe(bread, meat, cheese, toppings, condiments, meltedCheese, stay);

            Assert.AreEqual(false, burger.stay);
        }
    }
}