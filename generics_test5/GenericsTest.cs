// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型约束：引用类型约束和值类型约束
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test5
{
    class MyClass { }

    struct MyStruct { }

    class Gen<T> where T : class
    {
        T obj;
        public Gen()
        {
            obj = null;
        }
    }

    class Gen1<T> where T : struct
    {
        T obj;

        public Gen1(T x)
        {
            obj = x;
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            Gen<MyClass> x = new Gen<MyClass>();

            // error，类型实参必须为引用类型
            // Gen<int> x1 = new Gen<int>();

            Gen1<int> y = new Gen1<int>(5);
            Gen1<MyStruct> y1 = new Gen1<MyStruct>(new MyStruct());

            // error，类型实参必须为值类型
            // Gen1<MyClass> y2 = new Gen1<MyClass>(new MyClass());
        }
    }
}
