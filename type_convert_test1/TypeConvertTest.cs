// Copyright 2016.刘珅珅
// author：刘珅珅
// 表达式类型转换
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_convert_test1
{
    class TypeConvertTest
    {
        static void Main(string[] args)
        {
            decimal d = 9.5m;
            float f = 4.5f;
            // error，decimal类型不能和float、double混用
            // Console.WriteLine("d * f = {0}", d * f);

            ulong ul = 245UL;
            int i = 5;

            // error，ulong不能和任何有符合整数类型混用
            // Console.WriteLine("ul * i = {0}", ul * i);

            // ulong可以和有符合的浮点型混用，结果为float或double
            float f1 = ul * f;
            Console.WriteLine("ul * f = {0}", ul * f);

            uint ui = 5;

            // error，uint和sbyte，short，int混用时，结果为long
            // int b = ui * i;
            long l = ui * i;

            ushort us = 23;
            byte b = 2;
            char ch = 'X';

            // uint和ushort，byte，char混用时，结果为uint
            uint ua = ui * us;
            uint ub = ui * b;
            uint uc = ui * ch;

            byte b1 = 3;

            // byte和byte混用时，结果为int
            int i1 = b1 * b;
        }
    }
}
