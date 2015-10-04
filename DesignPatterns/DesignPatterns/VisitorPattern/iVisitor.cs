using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    interface iVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan loan);
    }
}
