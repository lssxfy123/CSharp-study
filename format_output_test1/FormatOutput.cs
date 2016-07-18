using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace format_output_test1
{
    class FormatOutput
    {
        // WriteLine("format string", arg0, arg1,...,argN);
        // 格式说明符{argnum, width:fmt}
        static void Main(string[] args)
        {
            Console.WriteLine("February has {0} or {1}", 28, 29);

            // February has         28 or    29
            Console.WriteLine("February has {0,10} or {1,5}", 28, 29);

            // Value   Squared Cubed
            // 1       1       1
            // 2       4       8
            // 3       9       27
            // 4       16      64
            // 5       25      125
            // 6       36      216
            // 7       49      343
            // 8       64      512
            // 9       81      729
            Console.WriteLine("Value\tSquared\tCubed");
            for (int i = 1; i < 10; ++i)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            }

            // 同C++类似，如果写成10/3则结果为3
            Console.WriteLine("Here is 10 / 3: {0:#.##}", 10.0 / 3);

            // Here is 10 / 3: 33.33
            Console.WriteLine("Here is 10 / 3: {0:#.##}", 100.0 / 3);

            // 123,456.56
            Console.WriteLine("{0:###,###.##}", 123456.56);
        }
    }
}
