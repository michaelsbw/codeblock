using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public interface iParty
    {
        int CommissionPercentage { get; set; }
        int Commission { get; set; }
        void SetCommission(int commission);
         
    }
}
