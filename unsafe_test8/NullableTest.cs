// Copyright 2016.刘珅珅
// author：刘珅珅
// 表达式中的可空类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test8
{
    class NullableTest
    {
        static void Main(string[] args)
        {
            int? count = null;
            int? result = null;

            int n = 10;  // 非可空类型
            result = count + n;  // 可空类型和非可空类型的结果为可空类型

            if (result.HasValue)
            {
                Console.WriteLine("result has value: " + result.Value);
            }
            else
                Console.WriteLine("result has no value");

            count = 100;
            result = count + n;

            if (result.HasValue)
            {
                Console.WriteLine("result has value: " + result.Value);
            }
            else
                Console.WriteLine("result has no value");

            // 可空对象赋值给非可空对象
            double? balance = null;
            double current_balance;  // 非可空对象

            // 如果balance为空，则赋值0.0给current_balance
            current_balance = balance ?? 0.0;
        }
    }
}
