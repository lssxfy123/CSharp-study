// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型：类型参数的默认值
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test6
{
    class MyClass
    {

    }

    class Gen<T>
    {
        public T obj;

        public Gen()
        {
            // 类型参数的默认值
            obj = default(T);
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            Gen<MyClass> x = new Gen<MyClass>();

            // 引用类型的默认值为null
            if (x.obj == null)
            {
                Console.WriteLine("x.obj is null.");
            }

            Gen<int> y = new Gen<int>();

            // 整型的默认值为0
            if (y.obj == 0)
            {
                Console.WriteLine("y.obj is 0.");
            }

            Gen<bool> z = new Gen<bool>();

            // bool型默认值为false
            if (z.obj == false)
            {
                Console.WriteLine("z.obj is false.");
            }

        }
    }
}
