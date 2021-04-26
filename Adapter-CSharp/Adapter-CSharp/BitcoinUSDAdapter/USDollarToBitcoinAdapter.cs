using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_CSharp.BitcoinUSDAdapter
{
    public class USDollarToBitcoinAdapter : IUSD
    {
        public USDollars usd;

        public USDollarToBitcoinAdapter(USDollars uSDollars)
        {
            this.usd = uSDollars;
        }

        public void Deposit(double amount)
        {
            var amountToAdd = amount * 48475.30;

            usd.Deposit(amountToAdd);
        }

        public double GetBalance()
        {
            double OriginalBalance = usd.GetBalance();

            var balance = OriginalBalance / 48475.30;

            return balance;
        }

        public void Withdraw(double amount)
        {
            var amountToWithdraw = amount * 48475.30;

            usd.Withdraw(amountToWithdraw);
        }
    }
}
