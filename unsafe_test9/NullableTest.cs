// Copyright 2016.刘珅珅
// author：刘珅珅
// 可空对象使用关系和逻辑运算符
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test9
{
    class NullableTest
    {
        static void Main(string[] args)
        {
            int? count = null;
            int? length = 16;
            Console.WriteLine(count < length);  // False
            Console.WriteLine(count == length);  // False
            Console.WriteLine(count > length);  // False

            int k = 8;
            Console.WriteLine(count < k);  // False
            Console.WriteLine(count > k);  // False
            Console.WriteLine(k < length);  // True

            bool? p = true;
            bool? q = null;
            Console.WriteLine(p | q);  // True
            Console.WriteLine(p & q);  // null

            p = false;
            Console.WriteLine(p | q);  // null
            Console.WriteLine(p & q);  // False

            p = null;
            Console.WriteLine(p | q);  // null
            Console.WriteLine(p & q);  // null

            Console.WriteLine(!p);  // null
        }
    }
}
