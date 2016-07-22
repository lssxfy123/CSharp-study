// Copyright 2016.刘珅珅
// author：刘珅珅
// 匿名方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_method_test1
{
    // 委托不能进行重载
    delegate void CountIt();
    delegate void CountOther(int end);

    class AnonymousMethodTest
    {
        static void Main(string[] args)
        {
            CountIt count = delegate  // 匿名方法
            {
                for (int i = 0; i <= 5; ++i)
                {
                    Console.WriteLine(i);
                }
            };
            count();

            Console.WriteLine();
            Console.WriteLine("with parameter:");

            CountOther count1 = delegate(int end)
            {
                for (int i = 0; i <= end; ++i)
                {
                    Console.WriteLine(i);
                }
            };

            count1(5);
        }
    }
}
