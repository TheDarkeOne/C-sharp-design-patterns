using System;
using System.Collections.Generic;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sandwich burger = new Burger();
            Sandwich sub = new subSandwich();
            string bread;
            string meat;
            string cheese;
            string order = new string("You ordered a ");
            bool add = true, add2 = true, mayo1 = false, ketchup = false,
                    mustard1 = false, mayo2 = false, mustard2 = false, meltedCheese = false, stay = false;
            string choice, answer, answer2;
            int bread1, meat1, cheese1;
            int choices, choices2, choices3, choices4;
            List<string> toppings = new List<string>();
            List<string> condiments = new List<string>();

            Console.WriteLine("Do you want a burger or a sub sandwich (burger/sub)? ");
            choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "burger":
                    order = string.Concat(order, "Burger with ");
                    bread = "Burger bun";
                    meat = "Burger patty";
                    cheese = "Cheddar";

                    do
                    {
                        Console.WriteLine("What do you want to add to your burger? 1. Lettuce 2. Tomato " +
                                "3. Pickles 4. Onions 5. Bacon 6. Finish");
                        choices = int.Parse(Console.ReadLine());

                        switch (choices)
                        {
                            case 1:
                                order = string.Concat(order, "lettuce, ");
                                toppings.Add("lettuce");
                                break;
                            case 2:
                                order = string.Concat(order, "tomato, ");
                                toppings.Add("tomato");
                                break;
                            case 3:
                                order = string.Concat(order, "pickles, ");
                                toppings.Add("pickles");
                                break;
                            case 4:
                                order = string.Concat(order, "onions, ");
                                toppings.Add("onions");
                                break;
                            case 5:
                                order = string.Concat(order, "bacon, ");
                                toppings.Add("bacon");
                                break;
                            case 6:
                                if (order.Equals("You ordered a burger with "))
                                {
                                    order = string.Concat(order, "no toppings");
                                }
                                add = false;
                                break;
                            default:
                                break;
                        }
                    } while (add);

                    do
                    {
                        Console.WriteLine("what condiment do you want? 1. Mayonnaise 2. Ketchup 3. Mustard 4. Finish");
                        choices2 = int.Parse(Console.ReadLine());
                        switch (choices2)
                        {
                            case 1:
                                if (!mayo1)
                                {
                                    order = string.Concat(order, "and mayonnaise ");
                                    condiments.Add("Mayonnaise");
                                    mayo1 = true;
                                }
                                break;
                            case 2:
                                if (!ketchup)
                                {
                                    order = string.Concat(order, "and ketchup ");
                                    condiments.Add("Ketchup");
                                    ketchup = true;
                                }
                                break;
                            case 3:
                                if (!mustard1)
                                {
                                    order = string.Concat(order, "and mustard ");
                                    condiments.Add("Mustard");
                                    mustard1 = true;
                                }
                                break;
                            case 4:
                                add2 = false;
                                break;
                            default:
                                break;
                        }
                    } while (add2);

                    Console.WriteLine("Do you want melted cheese (yes/no)? ");
                    answer = Console.ReadLine();

                    switch (answer.ToLower())
                    {
                        case "yes":
                            meltedCheese = true;
                            order = string.Concat(order, ", with melted cheese. ");
                            break;
                        case "no":
                            meltedCheese = false;
                            break;
                    }

                    Console.WriteLine("Do you want to stay or to go (stay/go)? ");
                    answer2 = Console.ReadLine();

                    switch (answer2.ToLower())
                    {
                        case "stay":
                            stay = true;
                            break;
                        case "go":
                            stay = false;
                            break;
                    }

                    Console.WriteLine(order);

                    Console.WriteLine("The cook is doing this to make your order ");
                    burger.prepareRecipe(bread, meat, cheese, toppings, condiments, meltedCheese, stay);

                    break;
                case "sub":
                    order = string.Concat(order, "Sub sandwich with ");

                    Console.WriteLine("What type of bread do you want? 1. Ciabatta 2. Whole wheat 3. Sourdough 4. Rye");
                    bread1 = int.Parse(Console.ReadLine());

                    switch (bread1)
                    {
                        case 1:
                            bread = "Ciabatta";
                            break;
                        case 2:
                            bread = "Whole Wheat";
                            break;
                        case 3:
                            bread = "Sourdough";
                            break;
                        case 4:
                            bread = "Rye";
                            break;
                        default:
                            bread = "Whole Wheat";
                            break;
                    }

                    Console.WriteLine("What type of meat do you want? 1. Roast beef 2. Turkey 3. Ham 4. Chicken");
                    meat1 = int.Parse(Console.ReadLine());

                    switch (meat1)
                    {
                        case 1:
                            meat = "Roast beef";
                            break;
                        case 2:
                            meat = "Turkey";
                            break;
                        case 3:
                            meat = "Ham";
                            break;
                        case 4:
                            meat = "Chicken";
                            break;
                        default:
                            meat = "Turkey";
                            break;
                    }

                    Console.WriteLine("What type of cheese do you want? 1. Cheddar 2. Swiss 3. Mozzarella 4. Pepper Jack");
                    cheese1 = int.Parse(Console.ReadLine());

                    switch (cheese1)
                    {
                        case 1:
                            cheese = "Cheddar";
                            break;
                        case 2:
                            cheese = "Swiss";
                            break;
                        case 3:
                            cheese = "Mozzarella";
                            break;
                        case 4:
                            cheese = "Pepper Jack";
                            break;
                        default:
                            cheese = "Cheddar";
                            break;
                    }

                    do
                    {
                        Console.WriteLine("What do you want to add to your burger? 1. Lettuce 2. Tomato " +
                                "3. Pickles 4. Onions 5. Bacon 6. Finish");
                        choices3 = int.Parse(Console.ReadLine());

                        switch (choices3)
                        {
                            case 1:
                                order = string.Concat(order, "lettuce, ");
                                toppings.Add("lettuce");
                                break;
                            case 2:
                                order = string.Concat(order, "tomato, ");
                                toppings.Add("tomato");
                                break;
                            case 3:
                                order = string.Concat(order, "pickles, ");
                                toppings.Add("pickles");
                                break;
                            case 4:
                                order = string.Concat(order, "onions, ");
                                toppings.Add("onions");
                                break;
                            case 5:
                                order = string.Concat(order, "bacon, ");
                                toppings.Add("bacon");
                                break;
                            case 6:
                                if (order.Equals("You ordered a Sub sandwich with "))
                                {
                                    order = string.Concat(order, "no toppings");
                                }
                                add = false;
                                break;
                            default:
                                break;
                        }
                    } while (add);

                    do
                    {
                        Console.WriteLine("what condiment do you want? 1. Mayonnaise 2. Mustard 3. Finish");
                        choices4 = int.Parse(Console.ReadLine());
                        switch (choices4)
                        {
                            case 1:
                                if (!mayo2)
                                {
                                    order = string.Concat(order, "and mayonnaise ");
                                    condiments.Add("Mayonnaise");
                                    mayo2 = true;
                                }
                                break;
                            case 2:
                                if (!mustard2)
                                {
                                    order = string.Concat(order, "and mustard ");
                                    condiments.Add("Mustard");
                                    mustard2 = true;
                                }
                                break;
                            case 3:
                                add2 = false;
                                break;
                            default:
                                break;
                        }
                    } while (add2);

                    Console.WriteLine("Do you want to stay or to go (stay/go)? ");
                    answer2 = Console.ReadLine();

                    switch (answer2.ToLower())
                    {
                        case "stay":
                            stay = true;
                            break;
                        case "go":
                            stay = false;
                            break;
                    }


                    Console.WriteLine(order);

                    Console.WriteLine("The cook is doing this to make your order ");
                    sub.prepareRecipe(bread, meat, cheese, toppings, condiments, false, stay);
                    break;
            }
        }
    }
}
