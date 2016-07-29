// Copyright 2016.刘珅珅
// author：刘珅珅
// 字符串比较
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test2
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string str1 = "alpha";
            string str2 = "Alpha";

            // 区分区域性比较
            int result = String.Compare(str1, str2, StringComparison.CurrentCulture);
            Console.Write("Using a culture-sensitive comparison: ");
            if (result < 0)
                Console.WriteLine(str1 + " is less than " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " is greater than " + str2);
            else
                Console.WriteLine(str1 + " equals " + str2);

            Console.WriteLine();

            // 序数值比较
            result = String.Compare(str1, str2, StringComparison.Ordinal);
            Console.Write("Using an ordinal comparison: ");
            if (result < 0)
                Console.WriteLine(str1 + " is less than " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " is greater than " + str2);
            else
                Console.WriteLine(str1 + " equals " + str2);

        }
    }
}
