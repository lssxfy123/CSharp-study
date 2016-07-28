// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ：表达式树
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace linq_test13
{
    class LINQTest
    {
        static void Main(string[] args)
        {
            // 声明一个Lambda表达式作为数据
            Expression<Func<int, int, bool>>
                IsFactorExp = (n, d) => (d != 0) ? (n % d) == 0 : false;

            // 将表达式数据转换为可执行代码
            Func<int, int, bool> IsFactor = IsFactorExp.Compile();

            // 执行表达式
            if (IsFactor(10, 5))
            {
                Console.WriteLine("5 is a factor of 10.");
            }

            if (!IsFactor(10, 7))
            {
                Console.WriteLine("7 is not a factor of 10.");
            }
        }
    }
}
