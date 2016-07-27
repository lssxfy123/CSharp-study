// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ：let子句
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test9
{
    class LINQTest
    {
        static void Main(string[] args)
        {
            string[] strs = { "alpha", "beta", "gamma"};

            // 使用let创建一个临时变量，存储嵌套from
            // 查询的数据源
            // 将strs字符串数组对应的字符数组按升序排列
            var chrs = from str in strs
                       let char_arry = str.ToCharArray()
                         from ch in char_arry
                         orderby ch
                         select ch;

            Console.WriteLine("The individual characters in sorted order:");

            foreach (char c in chrs)
                Console.Write(c + " ");

            Console.WriteLine();
        }
    }
}
