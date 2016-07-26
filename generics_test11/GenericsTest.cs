// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型接口的协变
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test11
{
    // 协变的泛型接口，使用out关键字
    public interface IMyCoVarGen<out T>
    {
        T GetObject();

        // T为协变，不能用于方法形参
        // void SetObject(T obj);
    }

    // 继承协变的泛型接口，接口中不再用
    // out关键字，泛型类中也不能用out，
    // 协变只能在泛型接口和泛型委托
    class MyClass<T> : IMyCoVarGen<T>
    {
        T obj;

        public MyClass(T v) { obj = v; }
        public T GetObject() { return obj; }
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
            IMyCoVarGen<Alpha> alpha_ref 
                = new MyClass<Alpha>(new Alpha("Alpha #1"));

            Console.WriteLine("Name of object is " + alpha_ref.GetObject().GetName());

            // 因为接口IMyCoVarGen是协变，所以可以这样赋值
            alpha_ref = new MyClass<Beta>(new Beta("Beta #1"));
            Console.WriteLine("Name of object is " + alpha_ref.GetObject().GetName());

            MyClass<Alpha> alpha = new MyClass<Alpha>(new Alpha("Alpha #2"));
            MyClass<Beta> beta = new MyClass<Beta>(new Beta("Beta #2"));

            // error，泛型类没有协变和逆变
            // alpha = beta;
        }
    }
}
