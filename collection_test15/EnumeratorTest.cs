// Copyright 2016.刘珅珅
// author：刘珅珅
// 枚举器
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test15
{
    class EnumeratorTest
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; ++i)
                list.Add(i);

            // 使用枚举器
            IEnumerator etr = list.GetEnumerator();

            while (etr.MoveNext())
                Console.Write(etr.Current + " ");

            Console.WriteLine();

            // 重置枚举器
            etr.Reset();

            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
            Console.WriteLine();
        }
    }
}
