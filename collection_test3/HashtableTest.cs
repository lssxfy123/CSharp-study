// Copyright 2016.刘珅珅
// author：刘珅珅
// Hashtable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test3
{
    class HashtableTest
    {
        static void Main(string[] args)
        {
            Hashtable hash_table = new Hashtable();

            hash_table.Add("house", "Dwelling");
            hash_table.Add("car", "Means of transport");
            hash_table.Add("book", "Collection of printed words");
            hash_table.Add("apple", "Edible fruit");

            hash_table["tractor"] = "Farm implement";

            // 获取键
            ICollection keys = hash_table.Keys;

            foreach (string str in keys)
                Console.WriteLine(str + " : " + hash_table[str]);
        }
    }
}
