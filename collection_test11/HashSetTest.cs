// Copyright 2016.刘珅珅
// author：刘珅珅
// HashSet：散列集
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test11
{
    class HashSetTest
    {
        static void Show(string msg, HashSet<char> set)
        {
            Console.Write(msg);
            foreach (char c in set)
                Console.Write(c + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            HashSet<char> hashSet1 = new HashSet<char>();
            HashSet<char> hashSet2 = new HashSet<char>();

            hashSet1.Add('A');
            hashSet1.Add('B');
            hashSet1.Add('C');

            hashSet2.Add('C');
            hashSet2.Add('D');
            hashSet2.Add('E');

            Show("Initial content of hashSet1: ", hashSet1);
            Show("Initial content of hashSet2: ", hashSet2);

            // 两个集合的不同元素
            hashSet1.SymmetricExceptWith(hashSet2);
            Show("hashSet1 after Symmetric difference with hashSet2: ", hashSet1);

            // 两个集合的并集
            hashSet1.UnionWith(hashSet2);
            Show("hashSet1 after union with hashSet2: ", hashSet1);

            // 一个集合剔除掉另一个集合
            hashSet1.ExceptWith(hashSet2);
            Show("hashSet1 after subtracting with hashSet2: ", hashSet1);
        }
    }
}
