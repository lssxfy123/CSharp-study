// Copyright 2016.刘珅珅
// author：刘珅珅
// 值传递与引用传递
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test3
{
    class MyClass
    {
        private int a;
        private int b = 3;

        public MyClass() { }

        public MyClass(int i, int j)
        {
            a = i;
            b = j;
        }

        public void Change(MyClass obj)
        {
            obj.a = obj.a + obj.b;
            obj.b = -obj.b;
        }

        public void Show()
        {
            Console.WriteLine(" a is " + a + " b is " + b);
        }
    }
    class ClassTest
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.Show();

            MyClass obj = new MyClass(15, 20);
            Console.Write("Before change: ");
            obj.Show();  // 15 20
            obj.Change(obj);
            Console.Write("After change: ");
            obj.Show();  // 35 -20
        }
    }
}
