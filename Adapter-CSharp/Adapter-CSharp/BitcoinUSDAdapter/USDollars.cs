using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_CSharp.BitcoinUSDAdapter
{
    public class USDollars : IUSD
    {
        double balance = 0;

        public USDollars()
        {
            balance = 100000;
        }
        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Not enough in account.\n");
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;

        }
    }
}
