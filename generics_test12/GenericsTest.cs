// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型接口的协变
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test12
{
    public interface IMyCoVarGen<out T>
    {
        T GetObject();
    }

    // 非协变类型形参
    public interface IMyCoVarGen2<T> : IMyCoVarGen<T>
    {
        void ShowType();
    }

    class MyClass<T> : IMyCoVarGen2<T>
    {
        T obj;

        public MyClass(T v) { obj = v; }
        public T GetObject() { return obj; }

        public void ShowType()
        {
            Console.WriteLine("T is " + typeof(T));
        }
    }

    class Alpha
    {
        string name;
        public Alpha(string n) { name = n; }
        public string GetName() { return name; }
    }

    class Beta : Alpha
    {
        public Beta(string n) : base(n) { }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            IMyCoVarGen2<Alpha> alpha_ref
    = new MyClass<Alpha>(new Alpha("Alpha #1"));

            Console.WriteLine("Name of object is " + alpha_ref.GetObject().GetName());

            // error，IMyCoVarGen2不是协变，
            // 也无法扩展IMyCoVarGen协变特性
            // alpha_ref = new MyClass<Beta>(new Beta("Beta #1"));
        }
    }
}
