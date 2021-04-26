using System;
using System.Collections.Generic;
using System.Text;

namespace BalancerPatternCSharp
{
    public class Balancer
    {
        private int number;
        private static int amount;
        private static Balancer uniqueInstance;
        private static Balancer Instance1;
        private static Balancer Instance2;
        private static Balancer Instance3;

        private Balancer(int num)
        {
            number = num;
        }

        public static Balancer getInstance()
        {
            if (Instance1 == null)
            {
                Instance1 = new Balancer(1);
                amount++;
                return Instance1;
            }
            else if (Instance2 == null)
            {
                Instance2 = new Balancer(2);
                amount++;
                return Instance2;
            }
            else if (Instance3 == null)
            {
                Instance3 = new Balancer(3);
                amount++;
                return Instance3;
            }
            else
            {
                amount++;
                int num = amount % 3;

                switch (num)
                {
                    case 1:
                        uniqueInstance = Instance1;
                        break;
                    case 2:
                        uniqueInstance = Instance2;
                        break;
                    case 0:
                        uniqueInstance = Instance3;
                        break;
                }
            }
            return uniqueInstance;
        }

        public void Display()
        {
            Console.WriteLine(" I am Balancer Instance " + number);
        }
    }
}
