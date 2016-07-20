// Copyright 2016.刘珅珅
// author：刘珅珅
// 命名实参
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace named_argument_test1
{
    class NamedArgs
    {
        public bool IsFactor(int val, int divisor)
        {
            if ((val % divisor) == 0)
            {
                return true;
            }
            return false;
        }
    }
    class NamedArgsTest
    {
        static void Main(string[] args)
        {
            NamedArgs obj = new NamedArgs();
            if (obj.IsFactor(10, 2))
            {
                Console.WriteLine("2 is factor of 10.");
            }

            // 使用命名参数传递实参
            if (obj.IsFactor(divisor: 2, val: 10))
            {
                Console.WriteLine("2 is factor of 10.");
            }

            // 位置参数与命名参数混用
            // 所有位置参数都必须在命名参数之前
            if (obj.IsFactor(10, divisor: 2))
            {
                Console.WriteLine("2 is factor of 10.");
            }
        }
    }
}
