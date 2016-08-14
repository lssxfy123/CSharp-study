// Copyright 2016.刘珅珅
// author：刘珅珅
// 命名迭代器
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test20
{
    class MyClass
    {
        char c = 'A';

        // 命名迭代器
        public IEnumerable MyIterator(int begin, int end)
        {
            for (int i = begin; i < end; ++i)
                yield return (char)(c + i);
        }
    }

    class NamedYieldTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine("Iterate letters from F to L:");
            foreach (char c in obj.MyIterator(5, 12))
                Console.Write(c + " ");

            Console.WriteLine();
        }
    }
}
