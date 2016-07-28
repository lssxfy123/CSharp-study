using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_test1
{
    public class MyClass
    {
        public bool IsDivBy(int a, int b)
        {
            if ((a % b) == 0) return true;
            return false;
        }

        public bool IsEven(int a)
        {
            if ((a % 2) == 0) return true;
            return false;
        }
    }
}
