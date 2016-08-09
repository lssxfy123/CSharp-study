// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型双向链表
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test9
{
    class LinkedListTest
    {
        static void Main(string[] args)
        {
            LinkedList<char> linked_list = new LinkedList<char>();
            linked_list.AddFirst('A');
            linked_list.AddFirst('B');
            linked_list.AddFirst('C');
            linked_list.AddFirst('D');
            linked_list.AddFirst('E');

            // 结点方式
            Console.Write("Display contents by following links: ");
            for (LinkedListNode<char> node = linked_list.First; node != null; node = node.Next)
                Console.Write(node.Value + " ");
            Console.WriteLine("\n");

            Console.Write("Display contents with foreach loop: ");
            foreach (char c in linked_list)
                Console.Write(c + " ");
            Console.WriteLine("\n");

            // 倒序显示
            Console.Write("Display contents backwards: ");
            for (LinkedListNode<char> node = linked_list.Last; node != null; node = node.Previous)
                Console.Write(node.Value + " ");
            Console.WriteLine("\n");

            linked_list.AddLast('K');
            Console.Write("Contents after addition to end: ");
            foreach (char c in linked_list)
                Console.Write(c + " ");
            Console.WriteLine("\n");
        }
    }
}
