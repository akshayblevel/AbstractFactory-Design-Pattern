﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ICICI : FixDeposit
    {
        public override void Deposit(double amount)
        {
            Console.WriteLine("Fix Deposit of INR " + amount + " is done in ICICI");
        }
    }
}
