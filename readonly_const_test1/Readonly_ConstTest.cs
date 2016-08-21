// Copyright 2016.刘珅珅
// author：刘珅珅
// readonly与const的区别
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_const_test1
{
    class MyClass {}

    class Test
    {
        static readonly MyClass r1 = new MyClass();
        // const MyClass c1 = new MyClass();  // error
        const MyClass c1 = null;
        const string c2 = "abc";
    }

    class Readonly_ConstTest
    {
        static readonly int A = B * 10;
        static readonly int B = 10;

        const int C = D * 10;
        const int D = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("A is {0}, B is {1}", A, B);
            Console.WriteLine("\nC is {0}, D is {1}", C, D);
        }
    }
}
