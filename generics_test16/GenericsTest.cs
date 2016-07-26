// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型接口协变和逆变的相互作用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test16
{
    // 逆变
    public interface IFoo<in T>
    {
    }

    // error
    //public interface IBar<in T>
    //{
    //    void Test(IFoo<T> foo);
    //}

    // 协变
    public interface IBar<out T>
    {
        // IFoo必须逆变类型形参T
        void Test(IFoo<T> foo);
    }

    class MyClass<T> : IBar<T>
    {
        public void Test(IFoo<T> foo) { }
    }

    class Foo<T> : IFoo<T> { }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            IBar<object> obj_bar = new MyClass<string>();

            IFoo<object> obj_foo = new Foo<object>();
            obj_bar.Test(obj_foo);
        }
    }
}
