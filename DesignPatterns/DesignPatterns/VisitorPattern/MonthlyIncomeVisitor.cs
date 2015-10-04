using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class MonthlyIncomeVisitor: iVisitor
    {
        public double MonthlyIncome { get; set; }
        public void Visit(Loan loan)
        {
            MonthlyIncome -= loan.MonthlyPayment;
        }

        public void Visit(BankAccount bankAccount)
        {
            MonthlyIncome += bankAccount.AccountBalance * bankAccount.MonthlyInterestRate;
        }

        public void Visit(RealEstate realEstate)
        {
            MonthlyIncome += realEstate.MonthlyRent;
        }
    }
}
