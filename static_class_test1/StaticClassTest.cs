// Copyright 2016.刘珅珅
// author：刘珅珅
// 静态类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_test1
{
    static class NumericFn
    {
        static public double FracPart(double num)
        {
            return num - (int)num;
        }

        static public bool IsEven(double num)
        {
            return (num % 2) == 0 ? true : false;
        }
    }
    class StaticClassTest
    {
        static void Main(string[] args)
        {
            if (NumericFn.IsEven(10))
            {
                Console.WriteLine("10 is even");
            }
            else
            {
                Console.WriteLine("10 is odd");
            }
        }
    }
}
