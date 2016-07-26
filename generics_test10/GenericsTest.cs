// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型继承：非泛型类为基类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test10
{
    class NonGen
    {
        int num;

        public NonGen(int i)
        {
            num = i;
        }

        public int GetNum()
        {
            return num;
        }
    }

    // 泛型类继承非泛型类
    class Gen<T> : NonGen
    {
        T obj;

        public Gen(T o, int i) : base(i)
        {
            obj = o;
        }

        public T GetObj()
        {
            return obj;
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            Gen<string> w = new Gen<string>("Hello", 47);
            Console.Write(w.GetObj() + " ");
            Console.WriteLine(w.GetNum());
        }
    }
}
