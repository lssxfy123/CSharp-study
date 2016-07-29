// Copyright 2016.刘珅珅
// author：刘珅珅
// 字符串的查找
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test3
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string str = "C# has powerful string handling.";
            Console.WriteLine("str: " + str);

            int index = str.IndexOf('h');
            Console.WriteLine("Index of first 'h': " + index);

            index = str.LastIndexOf('h');
            Console.WriteLine("Index of last 'h': " + index);

            char[] chrs = { 'a', 'b', 'c'};
            index = str.IndexOfAny(chrs);
            Console.WriteLine("Index of first 'a', 'b', or 'c': " + index);

            if (str.StartsWith("C# has"))
                Console.WriteLine("str begins with \"C# has\"");

            if (str.Contains("power"))
                Console.WriteLine("The sequence power was found.");
        }
    }
}
