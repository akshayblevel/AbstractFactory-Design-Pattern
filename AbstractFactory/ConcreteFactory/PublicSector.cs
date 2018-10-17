using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PublicSector : Investment
    {
        public override FixDeposit FD()
        {
            return new SBI();
        }

        public override MutualFund MF()
        {
            return new GovtFund();
        }
    }
}
