// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型动态数组
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test8
{
    class List
    {
        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>();
            queue.Enqueue('a');
            queue.Enqueue('b');
            queue.Enqueue('c');

            // 可以用队列Queue<T>给List传参
            // Queue<T>实现了IEnumerable<T>
            List<char> list = new List<char>(queue);

            Console.Write("Current contents: ");
            for (int i = 0; i < list.Count; ++i)
                Console.Write(list[i] + " ");

            Console.WriteLine("\n");

            Console.WriteLine("Removing 1 element.");
            list.Remove('c');

            Console.Write("Contents: ");
            foreach (char c in list)
                Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}
