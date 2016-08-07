// Copyright 2016.刘珅珅
// author：刘珅珅
// 非泛型类：ArrayList
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test2
{
    class ArrayListTest
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(55);
            array.Add(43);
            array.Add(-4);
            array.Add(88);
            array.Add(3);
            array.Add(19);

            Console.Write("Original contents: ");
            foreach (var i in array)
                Console.Write(i + " ");

            Console.WriteLine("\n");

            // 数组排序
            // 集合中的所有元素必须能够相互比较
            // 否则会抛出异常
            array.Sort();

            Console.Write("Contents after sorting: ");
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            // 搜索
            Console.WriteLine("Index of 43 is " + array.BinarySearch(43));

            // 将ArrayList转换为数组
            int[] iarray = (int[])array.ToArray(typeof(int));
        }
    }
}
