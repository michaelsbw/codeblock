using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class CompositePattern
    {
        public static void RunCompositePattern()
        {

            Console.WriteLine("Composite Pattern: Composite lets clients treat individual objects and compositions of objects uniformkly. Uses when you are dealing with groups or collections.");
            int totalCommision = 1000000;
            Console.WriteLine("The sales team are going to split {0} dollar bonus based on each one's percentage. ", totalCommision);
            SalesRep Tier2_Joe = new SalesRep("Tier2_Joe", 50);
            SalesRep Tier2_John = new SalesRep("Tier2_John", 50);
            SalesTeam Tier2Consulting = new SalesTeam { Name = "JJ Tier2Consulting", AllParties = { Tier2_Joe, Tier2_John }, CommissionPercentage = 40 };

            SalesRep Tier1_Ryan = new SalesRep("Tier1_Ryan", 30);
            SalesRep Tier1_Rich = new SalesRep("Tier1_Rich", 30);
            SalesTeam Tier1Consulting = new SalesTeam { Name = "JJ Tier1Consulting", AllParties = { Tier1_Ryan, Tier1_Rich, Tier2Consulting }, CommissionPercentage = 25 };

            SalesRep Alex = new SalesRep("Alex", 25);
            SalesRep Isabel = new SalesRep("Isabel", 25);
            SalesRep Michelle = new SalesRep("Michelle", 25);

            SalesTeam everyone = new SalesTeam { AllParties = { Alex, Isabel, Michelle, Tier1Consulting }, CommissionPercentage = 100 };

            everyone.SetCommission(totalCommision);
            Console.ReadLine();


        }
    }
}
