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
            // 通过断点调试可以看到obj_bar的T的实际类型为string
            // Test方法的实参类型为IFoo<string>，
            // 通过obj_bar调用Test方法，传递的实参为IFoo<object>
            // 如果传递IFoo<string>会发生编译错误，这样就要求
            // IFoo接口必须具有逆变类型形参，才能从IFoo<object>
            // 转换成IFoo<string>
            IBar<object> obj_bar = new MyClass<string>();

            IFoo<object> obj_foo = new Foo<object>();
            obj_bar.Test(obj_foo);
        }
    }
}
