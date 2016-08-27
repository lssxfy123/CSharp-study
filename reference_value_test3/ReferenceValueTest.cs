// Copyright 2016.刘珅珅
// author：刘珅珅
// 引用类型和值类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_value_test3
{
    class ReferenceValueTest
    {
        static void N(int j)
        {
            j = 10;
        }

        static void M(StringBuilder sb)
        {
            sb = null;
        }

        static void P(StringBuilder sb)
        {
            sb.Append(", World");
        }

        static void Main(string[] args)
        {
            int i = 5;
            N(i);

            // 按值传递，函数N内部的修改不会影响i的值
            Console.WriteLine(i);  // i = 5

            StringBuilder sb = new StringBuilder("Hello");
            M(sb);

            // 按值传递，函数M内部修改sb本身不会影响到sb
            Console.WriteLine(sb);  // Hello

            P(sb);

            // 在函数P中，修改了sb所指向的实例对象
            Console.WriteLine(sb); // Hello, World
        }
    }
}
