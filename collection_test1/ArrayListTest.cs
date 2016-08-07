// Copyright 2016.刘珅珅
// author：刘珅珅
// 非泛型集合：ArrayList
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test1
{
    class ArrayListTest
    {
        static void Main(string[] args)
        {
            // 创建一个array list
            ArrayList array = new ArrayList();

            Console.WriteLine("Initial number of elements: " + array.Count);

            Console.WriteLine();

            array.Add('C');
            array.Add('A');
            array.Add('E');
            array.Add('B');
            array.Add('F');

            // 添加不同类型的元素
            array.Add(5);

            Console.Write("Current contents: ");
            for (int i = 0; i < array.Count; ++i)
                Console.Write(array[i] + " ");

            Console.WriteLine();
            Console.WriteLine("Removing 2 elments");
            array.Remove('F');
            array.Remove('A');

            Console.Write("Current contents: ");
            for (int i = 0; i < array.Count; ++i)
                Console.Write(array[i] + " ");

            Console.WriteLine();
        }
    }
}
