// Copyright 2016.刘珅珅
// author：刘珅珅
// 接口继承
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test4
{
    public interface IA
    {
        void Method1();
        void Method2();
    }

    public interface IB : IA
    {
        void Method3();
    }

    class MyClass : IB
    {
        public void Method1()
        {
            Console.WriteLine("Implement Method1().");
        }

        public void Method2()
        {
            Console.WriteLine("Implement Method2().");
        }

        public void Method3()
        {
            Console.WriteLine("Implement Method3().");
        }
    }
    class InterfaceTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
        }
    }
}
