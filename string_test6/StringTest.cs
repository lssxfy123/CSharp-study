// Copyright 2016.刘珅珅
// author：刘珅珅
// 字符串插入、删除和替换
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test6
{
    class StringTest
    {
        static void Main(string[] args)
        {
            string str = "This test";
            Console.WriteLine("Original string: " + str);

            // 插入
            // 从索引位置5开始插入
            str = str.Insert(5, "is a ");
            Console.WriteLine(str);

            // 替换
            // 将所有的is替换成was
            str = str.Replace("is", "was");
            Console.WriteLine(str);

            // 删除
            // 从索引位置4开始删除5个字符
            str = str.Remove(4, 5);
            Console.WriteLine(str);
        }
    }
}
