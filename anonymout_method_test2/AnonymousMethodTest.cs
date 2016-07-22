// Copyright 2016.刘珅珅
// author：刘珅珅
// 带有返回值的匿名方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymout_method_test2
{
    delegate int CountIt(int end);

    class AnonymousMethodTest
    {
        static void Main(string[] args)
        {
            CountIt count = delegate(int end)
            {
                int sum = 0;
                for (int i = 0; i <= end; ++i)
                {
                    sum += i;
                }
                return sum;
            };

            int result = count(5);
            Console.WriteLine("Summation of 5 is " + result);
        }
    }
}
