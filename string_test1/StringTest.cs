// Copyright 2016.刘珅珅
// author：刘珅珅
// string类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test1
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string str = "A string";
            Console.WriteLine("str length is " + str.Length);
            Console.WriteLine("str[0] is " + str[0]);

            string str1 = str;
            // str1[0] = 'B';  // error,[]下标索引不能修改字符串
            str1 = str1.Replace("A", "B");
            Console.WriteLine("str is " + str);  // A string
            Console.WriteLine("str1 is " + str1);  // B string
            str1 = str1.Remove(3);
            Console.WriteLine("str1 is " + str1);

            // 字符串数组
            string[] str_array = { "This", "is", "a", "test."};
            Console.WriteLine("Original array: ");
            for (int i = 0; i < str_array.Length; ++i)
            {
                Console.Write(str_array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
