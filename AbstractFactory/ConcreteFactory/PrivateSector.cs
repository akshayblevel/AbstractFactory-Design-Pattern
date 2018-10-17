using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PrivateSector : Investment
    {
        public override FixDeposit FD()
        {
            return new ICICI();
        }

        public override MutualFund MF()
        {
            return new RelianceFund();
        }
    }
}
