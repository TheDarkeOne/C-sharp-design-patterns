using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_CSharp.BitcoinUSDAdapter
{
    public class BitcoinToUSDollarsAdapter : IBit
    {
        Bitcoin BitCoin;

        public BitcoinToUSDollarsAdapter(Bitcoin bitcoin)
        {
            BitCoin = bitcoin;
        }

        public void Deposit(double amount)
        {
            
            var amountToAdd = amount / 48475.30;

            BitCoin.Deposit(amountToAdd);
        }

        public double GetBalance()
        {
            return BitCoin.GetBalance() * 48475.30;
        }

        public void Withdraw(double amount)
        {
            var amountToWithdraw = amount / 48475.30;

            BitCoin.Withdraw(amountToWithdraw);
        }
    }
}
