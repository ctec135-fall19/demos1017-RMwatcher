using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class ChildClass : AbstractBaseClass
    {
        public override int abstractMethod(int num)
        {
            // throw new NotImplementedException();
            ChildClass cc = new ChildClass();
            Console.WriteLine(cc.abstractMethod(123));
        }
    }
}
