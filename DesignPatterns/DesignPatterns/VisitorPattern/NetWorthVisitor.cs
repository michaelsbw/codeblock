using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class NetWorthVisitor: iVisitor
    {
        public double NetWorth { get; set; }
        public void Visit(Loan loan)
        {
            NetWorth -= loan.LoanAmount;
        }

        public void Visit(BankAccount bankAccount)
        {
            NetWorth += bankAccount.AccountBalance;
        }

        public void Visit(RealEstate realEstate)
        {
            NetWorth += realEstate.PropertyValue;
        }
    }
}
