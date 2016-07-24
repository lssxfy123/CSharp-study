// Copyright 2016.刘珅珅
// author：刘珅珅
// RTTI运行时类型标识：typeof运算符
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace rtti_test3
{
    class RTTITest
    {
        static void Main(string[] args)
        {
            Type t = typeof(StreamReader);
            Console.WriteLine(t.FullName);

            if (t.IsClass)
            {
                Console.WriteLine("Is a class.");
            }

            if (t.IsAbstract)
            {
                Console.WriteLine("Is abstract.");
            }
            else
            {
                Console.WriteLine("Is concrete.");
            }
        }
    }
}
