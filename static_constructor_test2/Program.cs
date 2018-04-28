// Copyright 2018.刘珅珅
// author：刘珅珅
// 静态构造函数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_test2
{
    public class A
    {
        public static string textA;
        public string strText;

        // 静态构造函数只能有1个
        // 静态构造函数不能有参数
        // 静态构造函数不能有访问修饰符
        // 静态构造函数由.net框架调用
        // 静态构造函数只会调用1次
        static A()
        {
            Console.WriteLine("static constructor A");
            textA = "AAA";
        }

        public A()
        {
            Console.WriteLine("common constructor A");
            strText = "AAAAAAAA";
        }
    }

    public class B : A
    {
        public static string textB;

        static B()
        {
            Console.WriteLine("static constructor B");
            textA = "BBB";
            textB = "BBBAAA";
        }

        public B()
        {
            Console.WriteLine("common constructor B");
            strText = "BBBBBBBB";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A a1 = new A();
            Console.WriteLine(A.textA);
            Console.WriteLine();

            B b = new B();
            Console.WriteLine(A.textA);
            Console.WriteLine(B.textA);
            
        }
    }
}
