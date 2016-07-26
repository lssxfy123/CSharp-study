// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型接口的协变和逆变
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test14
{
    // 既有协变，又有逆变的泛型接口
    public interface IMyIF<out T, in V>
    {
        T GetObject();
        void Show(V v_obj);
    }

    public class MyClass<T, V> : IMyIF<T, V>
    {
        T obj;

        public MyClass(T o) { obj = o; }
 
        public T GetObject() { return obj; }

        public void Show(V v_obj) { Console.WriteLine(v_obj); }
    }

    class AlphaT
    {
        string name;
        public AlphaT(string n) { name = n; }
        public string GetName() { return name; }
    }

    class BetaT : AlphaT
    {
        public BetaT(string n) : base(n) { }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            // IMyIF接口的T类型为协变类型
            // 所以可以传递一个派生类类型
            // IMyIF接口的V类型为逆变类型
            // 所以可以传递一个基类类型
            IMyIF<AlphaT, BetaT> alpha_ref 
                = new MyClass<BetaT, AlphaT>(new BetaT("BetaT #1"));

            Console.WriteLine("Name of object is " + alpha_ref.GetObject().GetName());

            alpha_ref.Show(new BetaT("Beta T #2"));

            // error，alpha_ref的Show()接收BetaT对象
            // alpha_ref.Show(new AlphaT("AlphaT #1"));
        }
    }
}
