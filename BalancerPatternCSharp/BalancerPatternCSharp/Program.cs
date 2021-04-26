using System;

namespace BalancerPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Balancer balance = Balancer.getInstance();

            balance.Display();

            Balancer balance2 = Balancer.getInstance();

            balance2.Display();

            Balancer balance3 = Balancer.getInstance();

            balance3.Display();

            Balancer balance4 = Balancer.getInstance();

            balance4.Display();

            Balancer balance5 = Balancer.getInstance();

            balance5.Display();

            Balancer balance6 = Balancer.getInstance();

            balance6.Display();
        }
    }
}
