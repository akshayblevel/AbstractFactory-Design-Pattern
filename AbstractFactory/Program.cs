using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Investment investment = null;

            Console.WriteLine("Select Investment Area");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Public Sector");
            Console.WriteLine("2. Private Sector");
            Console.WriteLine("----------------------");

            switch (Console.ReadLine())
            {
                case "1":
                    investment = new PublicSector();
                    break;
                case "2":
                    investment = new PrivateSector();
                    break;
                default:
                    break;
            }

            investment.FD().Deposit(10000);
            Console.ReadLine();
        }
    }
}
