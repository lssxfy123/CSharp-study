// Copyright 2016.刘珅珅
// author：刘珅珅
// IEnumerator和IEnumerable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test17
{
    class MyClass : IEnumerable, IEnumerator
    {
        char[] chrs = { 'A', 'B', 'C', 'D'};
        int index = -1;

        // 实现IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // 实现IEnumerator
        public object Current
        {
            get { return chrs[index]; }
        }

        // 实现IEnumerator
        public bool MoveNext()
        {
            if (index == chrs.Length - 1)
            {
                Reset();
                return false;
            }

            ++index;
            return true;
        }

        // 实现IEnumerator
        public void Reset() { index = -1; }
    }

    class EnumTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            // 使用foreach循环遍历
            foreach (char c in obj)
                Console.Write(c + " ");

            Console.WriteLine();
        }
    }
}
