using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class RealEstate: iAsset
    {
        public int PropertyValue { get; set; }
        public double MonthlyRent { get; set; }

        public void Accept(iVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
