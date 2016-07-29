// Copyright 2016.刘珅珅
// author：刘珅珅
// 裁剪和填充字符串
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test5
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string str = "test";
            Console.WriteLine("Original string: " + str);

            // 字符串左边填充N个空格，是字符串总长度为10
            // 如果字符串本身的长度已经大于或等于10，
            // 则不做任何操作
            str = str.PadLeft(10);
            Console.WriteLine("|" + str + "|");

            // 字符串右边填充N个空格，是字符串总长度为20
            str = str.PadRight(20);
            Console.WriteLine("|" + str + "|");

            // 裁剪字符串
            // 裁剪字符串左右两边的空格
            str = str.Trim();
            Console.WriteLine("|" + str + "|");

            // 字符串左边填充N个#，是字符串总长度为10
            str = str.PadLeft(10, '#');
            Console.WriteLine(str);

            // 裁剪字符串左右两边的#
            str = str.Trim('#');
            Console.WriteLine(str);
        }
    }
}
