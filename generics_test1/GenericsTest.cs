// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test1
{
    class TwoGen<T, V>
    {
        T obj1;
        V obj2;

        public TwoGen(T o1, V o2)
        {
            obj1 = o1;
            obj2 = o2;
        }

        public void ShowType()
        {
            Console.WriteLine("Type of T is " + typeof(T));
            Console.WriteLine("Type of V is " + typeof(V));
        }

        public T GetObj1()
        {
            return obj1;
        }

        public V GetObj2()
        {
            return obj2;
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            TwoGen<int, string> obj = new TwoGen<int, string>(119, "Alpha");

            obj.ShowType();
        }
    }
}
