// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ：from子句嵌套
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test6
{
    class CharPair
    {
        public char First;
        public char Second;

        public CharPair(char c, char c2)
        {
            First = c;
            Second = c2;
        }
    }
    class LINQTest
    {
        static void Main(string[] args)
        {
            char[] chrs = { 'A', 'B', 'C'};
            char[] chrs2 = { 'X', 'Y', 'Z'};

            // 嵌套的from子句
            var pairs = from ch1 in chrs
                        from ch2 in chrs2
                        select new CharPair(ch1, ch2);

            Console.WriteLine("All combinations of ABC with XYZ: ");
            foreach (var p in pairs)
                Console.WriteLine("{0} {1}", p.First, p.Second);
        }
    }
}
