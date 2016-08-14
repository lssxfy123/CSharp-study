// Copyright 2016.刘珅珅
// author：刘珅珅
// 多个迭代器yield
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test19
{
    class MyClass
    {
        public IEnumerator GetEnumerator()
        {
            yield return 'A';
            yield return 'B';
            yield return 'C';
            yield return 'D';
            yield return 'E';
        }
    }

    class YieldTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            foreach (char c in obj)
                Console.WriteLine(c + " ");

            Console.WriteLine();
        }
    }
}
