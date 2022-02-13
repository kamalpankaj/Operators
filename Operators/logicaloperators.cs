using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class logicaloperators
    {
        public void logicakoperators()
        {
            int Num3 = 10, Num4 = 20;
            bool result
            //Logical Operators

            // OR operator
            result = (Num3 == Num4) || (Num3 > 5);
            Console.WriteLine(result);

            // AND operator
            result = (Num3 == Num4) && (Num3 > 5);
            Console.WriteLine(result);
            
        }
    }
}
