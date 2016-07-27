// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型接口逆变和协变的相互作用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test17
{
    // 逆变
    public interface IFooContra<in T> { }

    // 协变
    public interface IFooCo<out T> { }

    public interface IBar<out T, in V>
    {
        IFooContra<V> TestContra();
        IFooCo<T> TestCo();
    }

    class MyClass<T, V> : IBar<T, V>
    {
        public IFooContra<V> TestContra()
        {
            FooContra<V> foo = new FooContra<V>();
            return foo;
        }

        public IFooCo<T> TestCo()
        {
            FooCo<T> foo = new FooCo<T>();
            return foo;
        }
    }

    class FooContra<V> : IFooContra<V> { }

    class FooCo<T> : IFooCo<T> { }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            // 接口引用指向一个继承了接口的类对象，和
            // 基类引用指向一个派生类对象相同，接口中的
            // 方法为abstract，默认为虚方法，所以通过接口
            // 引用调用的方法其实是派生类实现的方法
            IBar<object, string> obj_bar = new MyClass<string, object>();

            // obj_bar第一个类型形参为协变类型，所以可以
            // 将string->object，第二个形参为逆变的，所以可以
            // 将object->string。obj_bar的TestCo方法的实际返回
            // 类型为IFooCo<string>，要将其返回给IFooCo<object>，
            // 所以IFooCo的类型形参为协变类型。obj_bar的TestContra
            // 方法的实际返回类型为IFooContra<object>，要将其返回
            // 给IFooContra<string>，所以IFooContra的类型形参为逆变
            IFooContra<string> foo = obj_bar.TestContra();
            IFooCo<object> foo1 = obj_bar.TestCo();
        }
    }
}
