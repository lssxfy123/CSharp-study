// Copyright 2016.刘珅珅
// author：刘珅珅
// readonly：只读关键字
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_test1
{
    class MyClass
    {
        // 可以这样初始化readonly字段
        public readonly int a = 0;

        public MyClass()
        {
            // 可以在构造函数中初始化readonly字段
            a = 5;
        }
    }

    struct MyStruct
    {
        public readonly int b;
    }
    class ReadonlyTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.a);  // 5
        }
    }
}
