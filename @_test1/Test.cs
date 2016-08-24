// Copyright 2016.刘珅珅
// author：刘珅珅
// 转义字符@的用法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __test1
{
    class Test
    {
        static void Main(string[] args)
        {
            // 使字符串中的\失去转义符的作用
            // 以下两个字符串的含义完全相同
            string path1 = @"C:\Windows\";
            string path2 = "C:\\Windows\\";

            // 字符串中的"要用""表示
            // 以下两个字符串的含义完全相同
            string str1 = @"aaa=""bbb""";
            string str2 = "aaa=\"bbb\"";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            // 保存换行符和空格
            string insert = @"
            insert into Users
            (UserID)";
            Console.WriteLine(insert);

            // 使用C#的关键字做变量
            string @operator = "+";
            string @class = "分类一";
            Console.WriteLine(@operator);
            Console.WriteLine(@class);

            // 作为sql语句里的一个标签，声明此处需要插入一个参数
            string sql = "delete from Category where CategoryID=@CategoryID";
        }
    }
}
