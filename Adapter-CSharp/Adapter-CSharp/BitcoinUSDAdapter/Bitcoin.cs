using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_CSharp.BitcoinUSDAdapter
{
    public class Bitcoin : IBit
    {
        List<double> bitcoin = new List<double>();

        public Bitcoin()
        {
            for (double i = 7.0; i > 0.0; i--)
                bitcoin.Add(i);


        }
        public double GetBalance()
        {
            double balance = 0.0;

            for (int i = 0; i < bitcoin.Count; i++)
            {
                balance += bitcoin.ElementAt(i);
            }

            return balance;
        }

        public void Withdraw(double amount)
        {
            bool finished = false;



            while (finished == false) 
            {
                double temp = bitcoin.ElementAt(0);

                bitcoin.Remove(temp);

                temp -= amount;

                if (temp < 0)
                {
                    amount = (temp * -1);
                }
                else 
                {
                    amount = 0;
                }


                if (amount == 0)
                {
                    if (temp != 0)
                    {
                        bitcoin.Add(temp);
                    }
                    finished = true;
                }
                else 
                {
                    finished = false;
                }

                
            }

        }

        public void Deposit(double amount)
        {
            bitcoin.Add(amount);
        }
    }
}
