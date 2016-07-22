// Copyright 2016.刘珅珅
// author：刘珅珅
// 语句Lambda
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_test2
{
    class LambdaTest
    {
        delegate void IntOp(int end);
        static void Main(string[] args)
        {
            // 语句Lambda
            IntOp fact = n => {
                int r = 1;
                for (int i = 1; i <= n; ++i)
                {
                    r = i * r;
                }
                Console.WriteLine("The factorial of {0} is {1}", n, r);
            };

            fact(5);
        }
    }
}
