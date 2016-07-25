// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型约束：new()约束
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test4
{
    class MyClass
    { }

    class MyClass2
    {
        public MyClass2()
        {

        }

        public MyClass2(int i)
        {

        }
    }

    class Gen<T> where T : new()
    {
        T obj;
        public Gen()
        {
            obj = new T();
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            // MyClass有默认的构造函数
            Gen<MyClass> x = new Gen<MyClass>();

            // MyClass2必须显示提供一个无参构造函数
            Gen<MyClass2> y = new Gen<MyClass2>();
        }
    }
}
