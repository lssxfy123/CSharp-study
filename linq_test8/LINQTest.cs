// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ：into子句，延续查询
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test8
{
    class LINQTest
    {
        static void Main(string[] args)
        {
            string[] web_sites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                                 "hsNameG.tv", "hsNameH.net", "hsNameI.tv"};

            // into子句，ws为后续查询的范围变量
            var web_addrs = from addr in web_sites
                                        where addr.LastIndexOf(".") != -1
                                        group addr by addr.Substring(addr.LastIndexOf(".")) into ws
                                        where ws.Count() > 2
                                        select ws;

            // 执行查询
            foreach (var sites in web_addrs)
            {
                Console.WriteLine("Web sites grouped by " + sites.Key);

                foreach (var site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}
