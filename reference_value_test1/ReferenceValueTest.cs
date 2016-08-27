// Copyright 2016.刘珅珅
// author：刘珅珅
// 值类型存储在堆上
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_value_test1
{
    delegate int CountIt(int end);
    class ReferenceValueTest
    {
        // 委托作为返回值
        static CountIt Counter()
        {
            int sum = 0;

            // 局部变量sum被匿名函数捕获
            CountIt obj = delegate(int end)
            {
                for (int i = 0; i <= end; ++i)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };

            return obj;
        }
        static void Main(string[] args)
        {
            CountIt count = Counter();
            int result = 0;

            result = count(3);
            Console.WriteLine("Summation of 3 is " + result);
            Console.WriteLine();

            result = count(5);
            Console.WriteLine("Summation of 5 is " + result);
        }
    }
}
