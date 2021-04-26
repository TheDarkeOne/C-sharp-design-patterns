using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_CSharp.BitcoinUSDAdapter
{
    public interface IBit
    {
        public double GetBalance();

        public void Withdraw(double amount);

        public void Deposit(double amount);
    }
}
