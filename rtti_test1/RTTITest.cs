// Copyright 2016.刘珅珅
// author：刘珅珅
// 运行时类型标识-is
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtti_test1
{
    class A { }
    class B : A { }

    class RTTITest
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            if (a is A)
            {
                Console.WriteLine("a is an A");
            }

            if (b is A)
            {
                Console.WriteLine("b is an A because it is derived from A");
            }

            if (a is B)
            {
                Console.WriteLine("a is B");
            }
            else
            {
                Console.WriteLine("a is not B");
            }

            if (a is object)
            {
                Console.WriteLine("a is an object");
            }
        }
    }
}
