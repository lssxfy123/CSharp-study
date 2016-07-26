// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test8
{
    // 泛型委托
    delegate T Op<T>(T v);

    class MyClass
    {
        public int Sum(int v)
        {
            int result = 0;
            for (int i = v; i > 0; --i)
                result += i;

            return result;
        }

        public string Reflect(string src)
        {
            string result = "";
            foreach (char ch in src)
                result = ch + result;

            return result;
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Op<int> del_int = obj.Sum;
            Console.WriteLine(del_int(3));

            Op<string> del_str = obj.Reflect;
            Console.WriteLine(del_str("Hello"));
        }
    }
}
