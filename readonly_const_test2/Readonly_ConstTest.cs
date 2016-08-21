// Copyright 2016.刘珅珅
// author：刘珅珅
// readonly与const区别
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using readonly_const_dll;

namespace readonly_const_test2
{
    class Readonly_ConstTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("readonly pi " + ReadonlyConst.pi);
            Console.WriteLine("const pi " + ReadonlyConst.PI);
            Console.ReadKey();
        }
    }
}
