// Copyright 2016.刘珅珅
// author：刘珅珅
// 表达式Lambda
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_test1
{
    delegate int Incr(int v);

    delegate bool IsEven(int v);

    class LambdaTest
    {
        static void Main(string[] args)
        {
            // 表达式Lambda与委托
            Incr incr = count => count + 2;
            int x = -10;
            while (x <= 0)
            {
                x = incr(x);
            }

            IsEven is_even = n => n % 2 == 0;

            for (int i = 0; i <= 10; ++i)
            {
                if (is_even(i))
                {
                    Console.WriteLine(i + " is even.");
                }
            }
        }
    }
}
