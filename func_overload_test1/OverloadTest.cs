// Copyright 2016.刘珅珅
// author：刘珅珅
// 函数重载
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_overload_test1
{
    class Overload
    {
        public void MyMeth(int x)
        {
            Console.WriteLine("Inside MyMeth(int): " + x);
        }

        public void MyMeth(double x)
        {
            Console.WriteLine("Inside MyMeth(double): " + x);
        }
    }

    class OverloadTest
    {
        static void Main(string[] args)
        {
            Overload obj = new Overload();
            int i = 10;
            double d = 10.1;

            obj.MyMeth(i); // MyMeth(int)
            obj.MyMeth(d);  // MyMeth(double)

            byte b = 99;
            short s = 10;
            float f = 11.5F;

            obj.MyMeth(b);  // MyMeth(int)
            obj.MyMeth(s);  // MyMeth(int)
            obj.MyMeth(f);  // MyMeth(double)
        }
    }
}
