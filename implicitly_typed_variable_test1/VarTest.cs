using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace implicitly_typed_variable_test1
{
    class VarTest
    {
        static void Main(string[] args)
        {
            var s1 = 4.0;
            Console.WriteLine("type is {0}", s1.GetType());  // System.Double
            var s2 = 5.0;

            var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.WriteLine("{0:#.###}", hypot);

            // s1 = 12.2M; // error，s1的类型已确定，是double型
        }
    }
}
