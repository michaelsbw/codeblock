using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class Person: iAsset
    {
        public List<iAsset> Assets;
        public Person (){
            Assets = new List<iAsset>();
        }
        public void Accept(iVisitor visitor)
        {
            foreach (iAsset asset in Assets)
            {
                asset.Accept(visitor);
            }

        }
    }
}
