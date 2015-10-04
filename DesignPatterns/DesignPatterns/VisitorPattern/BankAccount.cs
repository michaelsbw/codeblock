using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class BankAccount: iAsset
    {
        public int AccountBalance { get; set; }
        public double MonthlyInterestRate { get; set; }

        public void Accept(iVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
