// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ查询：group子句
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test7
{
    class LINQTest
    {
        static void Main(string[] args)
        {
            string[] web_sites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                                 "hsNameG.tv", "hsNameH.net", "hsNameI.tv"};

            // 查询变量web_addrs是IEnumerable<IGrouping<string, string> >
            IEnumerable<IGrouping<string, string> > web_addrs = from addr in web_sites
                            where addr.LastIndexOf(".") != -1
                            group addr by addr.Substring(addr.LastIndexOf("."));

            // 执行查询
            foreach (IGrouping<string, string> sites in web_addrs)
            {
                Console.WriteLine("Web sites grouped by " + sites.Key);

                foreach (string site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}
