// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ查询
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test2
{
    class LINQTest
    {
        static void Main(string[] args)
        {
            string[] strs = { ".com", ".net", "hsNameA.com", "hsNameB.net", 
                                     "test", ".network", "hsNameC.net", "hsNameD.com"};

            var net_addrs = from addr in strs
                            where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
                            select addr;

            // 执行查询的迭代变量为var
            foreach (var str in net_addrs)
                Console.WriteLine(str);
        }
    }
}
