// Copyright 2016.刘珅珅
// author：刘珅珅
// SortedList
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test4
{
    class SortedListTest
    {
        static void Main(string[] args)
        {
            SortedList sorted_list = new SortedList();

            sorted_list.Add("house", "Dwelling");
            sorted_list.Add("car", "Means of transport");
            sorted_list.Add("book", "Collection of printed words");
            sorted_list.Add("apple", "Edible fruit");

            sorted_list["tractor"] = "Farm implement";

            ICollection keys = sorted_list.Keys;

            Console.WriteLine("Contents of list via indexer.");

            // SortedList中的元素是按键排序的
            foreach (string str in keys)
                Console.WriteLine(str + " : " + sorted_list[str]);

            Console.WriteLine();

            Console.WriteLine("Contents by integer indexed.");
            for (int i = 0; i < sorted_list.Count; ++i)
                Console.WriteLine(sorted_list.GetByIndex(i));
        }
    }
}
