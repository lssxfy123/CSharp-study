// Copyright 2016.刘珅珅
// author：刘珅珅
// 扩展方法
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test14
{
    static class MyExtendMethods
    {
        // 可以被doube类型使用的扩展方法
        public static double Reciprocal(this double v)
        {
            return 1.0 / v;
        }

        // 可以被string类型使用的扩展方法
        public static string RevCase(this string str)
        {
            string temp = "";

            foreach (char ch in str)
            {
                if (Char.IsLower(ch))
                {
                    temp += Char.ToUpper(ch, CultureInfo.CurrentCulture);
                }
                else
                {
                    temp += Char.ToLower(ch, CultureInfo.CurrentCulture);
                }
            }
            return temp;
        }

        // 可以被double类型使用的扩展方法
        public static double AbsDivideBy(this double n, double d)
        {
            return Math.Abs(n / d);
        }
    }

    class LINQTest
    {
        static void Main(string[] args)
        {
            double val = 8.0;
            string str = "Alpha Beta Gamma";

            // 扩展方法为静态方法，但其调用却类似于实例方法
            Console.WriteLine("Reciprocal of {0} is {1}", val, val.Reciprocal());

            Console.WriteLine(str + " after reversing case is "
                                            + str.RevCase());

            Console.WriteLine("Result of abs divide by -2: " + val.AbsDivideBy(-2));
        }
    }
}
