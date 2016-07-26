// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test7
{
    class ArrayUtils
    {
        // 非泛型类的泛型方法
        public static bool CopyInsert<T>(T e, uint idx, T[] src, T[] target)
        {
            if (target.Length < src.Length + 1)
                return false;

            for (int i = 0, j = 0; i < src.Length;++i, ++j )
            {
                if (i == idx)
                {
                    target[j] = e;
                    ++j;
                }
                target[j] = src[i];
            }
                return true;
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            int[] src = { 1, 2, 3};
            int[] target = new int[4];

            Console.Write("Contents of src: ");
            foreach (int x in src)
                Console.Write(x + " ");

            Console.WriteLine();

            // 泛型方法
            ArrayUtils.CopyInsert(99, 2, src, target);

            Console.Write("Contents of target: ");
            foreach (int x in target)
                Console.Write(x + " ");

            Console.WriteLine();
        }
    }
}
