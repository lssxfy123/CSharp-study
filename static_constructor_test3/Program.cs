// Copyright 2018.刘珅珅
// author：刘珅珅
// 静态构造函数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_test3
{
    public class A
    {
        static A()
        {
            Console.WriteLine("static constructor A");
        }

        public A()
        {
            Console.WriteLine("common constructor A");
        }
    }

    public class B : A
    {
        static B()
        {
            Console.WriteLine("static constructor B");
        }

        public B()
        {
            Console.WriteLine("common constructor B");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
        }
    }
}
