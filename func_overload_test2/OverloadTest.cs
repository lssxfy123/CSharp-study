// Copyright 2016.刘珅珅
// author：刘珅珅
// 函数重载
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_overload_test2
{
    class Overload
    {
        public void MyMeth(int x)
        {
            Console.WriteLine("Inside MyMeth(int): " + x);
        }

        // 只增加了ref关键字可以与上面的函数构成重载
        public void MyMeth(ref int x)
        {
            Console.WriteLine("Inside MyMeth(ref int): " + x);
        }

        //public void MyMeth(out int x)  // error，不能与ref int构成重载
        //{
        //    x = 10;
        //}
    }

    class OverloadTest
    {
        static void Main(string[] args)
        {
            Overload obj = new Overload();
            int i = 10;
            obj.MyMeth(i);  // call MyMeth(int)
            obj.MyMeth(ref i);  // call MyMeth(ref int)
        }
    }
}
