// Copyright 2016.刘珅珅
// author：刘珅珅
// 拷贝对象
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_test1
{
    public class MyClass
    {
        public int n;

        public MyClass(int k)
        {
            Console.WriteLine("MyClass(int)");
            n = k;
        }

        public MyClass(MyClass rhs)
        {
            Console.WriteLine("MyClass(MyClass)");
            n = rhs.n;
        }
    }

    class CopyTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            MyClass obj1 = new MyClass(obj);

            MyClass copy = obj;  // 不会调用构造函数
        }
    }
}
