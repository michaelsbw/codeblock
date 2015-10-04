using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class SalesTeam: iParty
    {
        public List<iParty> AllParties { get; set; }
        public int CommissionPercentage { get; set; }
        public int Commission { get; set; }
        public string Name { get; set; }

        public SalesTeam()
        {
            AllParties = new List<iParty>();
        }

        public void SetCommission(int commission)
        {
            foreach (iParty sales in AllParties)
            {
                sales.Commission = commission * sales.CommissionPercentage / 100;
                sales.SetCommission(sales.Commission);
            }
        }
    }
}
