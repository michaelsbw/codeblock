using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class Loan: iAsset
    {
        public int LoanAmount { get; set; }
        public int MonthlyPayment { get; set; }

        public void Accept(iVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
