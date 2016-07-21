// Copyright 2016.刘珅珅
// author：刘珅珅
// 结构
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_test1
{
    struct Book
    {
        public string Author;
        public string Title;
        public int Copyright;

        public Book(string a, string t, int c)
        {
            Author = a;
            Title = t;
            Copyright = c;
        }
    }

    class StructTest
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Herb", "C# 4.0", 2012);
            Book book2 = new Book();  // 默认构造函数
            Book book3;  // 不使用new操作符，不会初始化

            Console.WriteLine("book1 title " + book1.Title);

            // book2.Title为null
            Console.WriteLine("book2 title " + book2.Title);

            // error，book3.Title未初始化
            // Console.WriteLine("book3 title " + book3.Title);  

            book3.Title = "Red Storm";
            Console.WriteLine("book3 title " + book3.Title);
        }
    }
}
