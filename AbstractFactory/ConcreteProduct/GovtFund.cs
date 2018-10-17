using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GovtFund : MutualFund
    {
        public override void Deposit(double amount)
        {
            Console.WriteLine("Mutual Fund of INR " + amount + " is done in Goverment Fund");
        }
    }
}
