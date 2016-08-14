// Copyright 2016.刘珅珅
// author：刘珅珅
// 字典枚举器：IDictionaryEnumerator
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test16
{
    class DictionaryEnumeratorTest
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();

            hash.Add("Tom", "555-3456");
            hash.Add("Mary", "555-9876");
            hash.Add("Todd", "555-3452");
            hash.Add("Ken", "555-7756");

            // 字典枚举器
            IDictionaryEnumerator etr = hash.GetEnumerator();
            Console.WriteLine("Display info using Entry.");
            while (etr.MoveNext())
                Console.WriteLine(etr.Entry.Key + " : " + etr.Entry.Value);

            Console.WriteLine();

            Console.WriteLine("Display info using Key and Value directly.");
            etr.Reset();
            while (etr.MoveNext())
                Console.WriteLine(etr.Key + " : " + etr.Value);
        }
    }
}
