// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型类的继承
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test9
{
    class Gen<T>
    {
        T obj;

        public Gen(T o)
        {
            obj = o;
        }

        public T GetObj()
        {
            return obj;
        }
    }

    // 派生类可以有自己自有的类型参数
    // 但必须给泛型基类传递基类的类型参数
    class Gen2<T, V> : Gen<T>
    {
        V obj;

        public Gen2(T o, V o2) : base(o)
        {
            obj = o2;
        }

        public V GetObj2()
        {
            return obj;
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            Gen2<string, int> x = new Gen2<string, int>("Value is: ", 99);
            Console.WriteLine(x.GetObj());
            Console.WriteLine(x.GetObj2());

            Console.WriteLine();

            Gen<string> base_x = x;
            Console.WriteLine(base_x.GetObj());

            // error，基类的类型实参与派生类的类型实参不一致
            // Gen<int> base_y = x;
        }
    }
}
