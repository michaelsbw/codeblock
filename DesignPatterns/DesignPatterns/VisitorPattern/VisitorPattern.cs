using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class VisitorPattern
    {
        public static void RunVisitorPattern()
        {
            
            Console.WriteLine("Visitor pattern represents an operatoin to be performed on the elements of an object structure. It lets you define a new operation without changing the classes of the elements on which it operates.");

            Console.WriteLine("");
            Person person = new Person();
            person.Assets.Add(new BankAccount { AccountBalance = 50000, MonthlyInterestRate = 0.02 });
            person.Assets.Add(new BankAccount { AccountBalance = 30000, MonthlyInterestRate = 0.01 });
            person.Assets.Add(new RealEstate { PropertyValue = 500000, MonthlyRent = 2500 });
            person.Assets.Add(new RealEstate { PropertyValue = 750000, MonthlyRent = 3200 });
            person.Assets.Add(new Loan { LoanAmount = 300000, MonthlyPayment = 2100 });
            person.Assets.Add(new Loan { LoanAmount = 200000, MonthlyPayment = 1600 });

            MonthlyIncomeVisitor monthlyIncomeVisitor = new MonthlyIncomeVisitor();
            NetWorthVisitor netWorthVisitor = new NetWorthVisitor();

            person.Accept(monthlyIncomeVisitor);
            person.Accept(netWorthVisitor);

            Console.WriteLine("Your monthly income is {0}", monthlyIncomeVisitor.MonthlyIncome);
            Console.WriteLine("Your net worth is {0}", netWorthVisitor.NetWorth);
            Console.ReadLine();

        }
    }
}
