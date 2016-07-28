// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ：使用join和into创建组连接
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test12
{
    class Transport
    {
        public string Name { get; set; }
        public string How { get; set; }

        public Transport(string n, string h)
        {
            Name = n;
            How = h;
        }
    }

    class LINQTest
    {
        static void Main(string[] args)
        {
            string[] travel_types = { "Air", "Sea", "Land"};

            Transport[] transports = { 
                                         new Transport("Bicycle", "Land"),
                                         new Transport("Balloon", "Air"),
                                         new Transport("Boat", "Sea"),
                                         new Transport("Jet", "Air"),
                                         new Transport("Canoe", "Sea"),
                                         new Transport("Biplane", "Air"),
                                         new Transport("Car", "Land"),
                                         new Transport("Cargo Ship", "Sea"),
                                         new Transport("Train", "Land")
                                     };

            // 创建组连接
            var by_how = from how in travel_types
                         join trans in transports
                         on how equals trans.How
                         into lst
                         select new { How = how, Tlist = lst };

            // 执行查询
            foreach (var t in by_how)
            {
                Console.WriteLine("{0} transportation includes:", t.How);

                foreach (var m in t.Tlist)
                    Console.WriteLine(" " + m.Name);

                Console.WriteLine();
            }
        }
    }
}
