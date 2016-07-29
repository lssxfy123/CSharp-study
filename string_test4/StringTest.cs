// Copyright 2016.刘珅珅
// author：刘珅珅
// 拆分和合并字符串
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test4
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string str = "One if by land, two if sea.";
            char[] seps = { ' ', '.', ','};

            // 拆分字符串
            // 拆分后的子字符串会出现空字符串""
            string[] parts = str.Split(seps);

            // 拆分后的子字符串去除了空字符串""
            string[] parts1 = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Pieces from split: ");

            for (int i = 0; i < parts.Length; ++i)
                Console.WriteLine(parts[i]);

            Console.WriteLine();
            Console.WriteLine("remove empty");
            for (int j = 0; j < parts1.Length; ++j)
                Console.WriteLine(parts1[j]);

            Console.WriteLine();

            // 合并字符串
            string whole = String.Join("|", parts1);
            Console.WriteLine("Result of join: ");
            Console.WriteLine(whole);
        }
    }
}
