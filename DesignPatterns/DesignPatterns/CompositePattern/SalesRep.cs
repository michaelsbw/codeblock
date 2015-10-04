using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class SalesRep: iParty
    {
        public int CommissionPercentage { get; set; }
        public int Commission { get; set; }
        public string Name { get; set; }

        public SalesRep(string name, int commissionPercentage)
        {
            Name = name;
            CommissionPercentage = commissionPercentage;

        }

        public void SetCommission(int commission)
        {
            Console.WriteLine("{0} gets {1} commission for his/her {2} percentage", Name, Commission, CommissionPercentage);
             
        }
    }
}
