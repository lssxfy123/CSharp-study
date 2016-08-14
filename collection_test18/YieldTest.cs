// Copyright 2016.刘珅珅
// author：刘珅珅
// 迭代器
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test18
{
    class MyClass
    {
        char c = 'A';

        // 隐式实现IEnumerable
        public IEnumerator GetEnumerator()
        {
            // 迭代器
            // yield每次返回一个元素
            for (int i = 0; i < 5; ++i)
            {
                Console.Write("GetEnumerator {0} ", i);
                yield return (char)(c + i);
            }
                
        }
    }
    class YieldTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            foreach (char c in obj)
                Console.WriteLine(" " + c );

            Console.WriteLine();
        }
    }
}
