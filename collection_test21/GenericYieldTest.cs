// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型迭代器
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test21
{
    class MyClass<T>
    {
        T[] array;

        public MyClass(T[] a)
        {
            array = a;
        }

        // 泛型迭代器
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T obj in array)
                yield return obj;
        }
    }

    class GenericYieldTest
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            MyClass<int> obj1 = new MyClass<int>(nums);

            foreach (var x in obj1)
                Console.Write(x + " ");

            Console.WriteLine();

            bool[] bVals = { true, true, false, false};
            MyClass<bool> obj2 = new MyClass<bool>(bVals);

            foreach (var b in obj2)
                Console.Write(b + " ");

            Console.WriteLine();
        }
    }
}
