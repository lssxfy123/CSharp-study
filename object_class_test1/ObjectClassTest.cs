// Copyright 2016.刘珅珅
// author：刘珅珅
// object类和装箱拆箱
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_class_test1
{
    class ObjectClassTest
    {
        static void Main(string[] args)
        {
            int x = 10;
            object obj;
            obj = x;  // 装箱

            Console.WriteLine(10.ToString());  // 自动装箱

            int y = (int)obj;  // 拆箱

            Console.WriteLine(y);  // 10
        }
    }
}
