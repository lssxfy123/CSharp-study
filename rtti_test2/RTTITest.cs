// Copyright 2016.刘珅珅
// author：刘珅珅
// RTTI运行时类型标识符：as运算符
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtti_test2
{
    class A { }

    class B : A { }

    class RTTITest
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            b = a as B;
            if (b == null)
            {
                Console.WriteLine("The cast in b = (B) a is NOT allowed.");
            }
            else
            {
                Console.WriteLine("The cast in b = (B) a is allowed.");
            }
        }
    }
}
