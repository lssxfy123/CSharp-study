// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型约束：基类约束
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test2
{
    class A
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }

    class B : A { }

    class C { }

    class Gen<T> where T : A
    {
        T obj;
        public Gen(T o)
        {
            obj = o;
        }

        public void SayHello()
        {
            obj.Hello();
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            Gen<A> g1 = new Gen<A>(a);
            g1.SayHello();

            Gen<B> g2 = new Gen<B>(b);
            g2.SayHello();

            // error，C不是A的派生类
            // Gen<C> g3 = new Gen<C>(c);

        }
    }
}
