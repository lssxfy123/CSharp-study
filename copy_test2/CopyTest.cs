// Copyright 2016.刘珅珅
// author：刘珅珅
// 类的拷贝
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_test2
{
    class X
    {
        public int a;
        public X(int x) 
        {
            Console.WriteLine("construct X.");
            a = x;
        }
    }

    // 深拷贝
    class MyDeepCopyClass : ICloneable
    {
        public X obj;
        public int b;

        public MyDeepCopyClass(int x, int y)
        {
            obj = new X(x);
            b = y;
        }

        public void Show(string name)
        {
            Console.Write(name + " values are ");
            Console.WriteLine("obj.a : {0}, b: {1}", obj.a, b);
        }

        public object Clone()
        {
            MyDeepCopyClass temp = new MyDeepCopyClass(obj.a, b);
            return temp;
        }
    }

    // 浅拷贝
    class MyCopyClass : ICloneable
    {
        public X obj;
        public int b;

        public MyCopyClass(int x, int y)
        {
            obj = new X(x);
            b = y;
        }

        public void Show(string name)
        {
            Console.Write(name + " values are ");
            Console.WriteLine("obj.a : {0}, b: {1}", obj.a, b);
        }

        public object Clone()
        {
            MyCopyClass temp = (MyCopyClass) MemberwiseClone();
            return temp;
        }
    }

    class CopyTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deep copy.");
            MyDeepCopyClass obj1 = new MyDeepCopyClass(10, 20);
            obj1.Show("obj1");

            // 深拷贝
            MyDeepCopyClass obj2 = (MyDeepCopyClass)obj1.Clone();
            obj2.Show("obj2");

            obj1.obj.a = 99;
            obj1.b = 88;

            Console.WriteLine();
            obj1.Show("obj1");
            obj2.Show("obj2");

            Console.WriteLine();
            Console.WriteLine("Copy.");
            MyCopyClass obj3 = new MyCopyClass(30, 40);
            obj3.Show("obj3");

            // 浅拷贝
            MyCopyClass obj4 = (MyCopyClass)obj3.Clone();
            obj4.Show("obj4");

            obj3.obj.a = 111;
            obj3.b = 222;

            Console.WriteLine();
            obj3.Show("obj3");
            obj4.Show("obj4");
        }
    }
}
