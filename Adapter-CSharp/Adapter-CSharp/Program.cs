using Adapter_CSharp.BitcoinUSDAdapter;
using Adapter_CSharp.TurkeyDuckAdapter;
using System;

namespace Adapter_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");
            testDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            testDuck(turkeyAdapter);

            Bitcoin bitcoin = new Bitcoin();

            USDollars usd = new USDollars();

            IBit bitAdapter = new BitcoinToUSDollarsAdapter(bitcoin);

            IUSD usdAdapter = new USDollarToBitcoinAdapter(usd);

            Console.WriteLine($"\nYou have ${usd.GetBalance()} in your account.");

            Console.WriteLine($"\nYou have {bitcoin.GetBalance()} bitcoins in your account.");

            bitAdapter.Deposit(5000);

            usdAdapter.Deposit(1.5);

            Console.WriteLine($"\nYou have ${usd.GetBalance()} in your account.");

            Console.WriteLine($"\nYou have {bitcoin.GetBalance()} bitcoins in your account.");
        }



        static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
