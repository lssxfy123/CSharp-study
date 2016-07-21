// Copyright 2016.刘珅珅
// author：刘珅珅
// 接口显式实现：消除多义性
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test6
{
    interface IMyIA
    {
        void Method(int x);
    }

    interface IMyIB
    {
        void Method(int x);
    }

    class MyClass : IMyIA, IMyIB
    {
        void IMyIA.Method(int x)
        {
            Console.WriteLine("IMyIA::Method " + (x + x));
        }

        void IMyIB.Method(int x)
        {
            Console.WriteLine("IMyIB::Method " + (x * x));
        }
    }

    class InterfaceTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            IMyIA iA = (IMyIA)obj;
            iA.Method(3);

            IMyIB iB = (IMyIB)obj;
            iB.Method(3);
        }
    }
}
