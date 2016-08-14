// Copyright 2016.刘珅珅
// author：刘珅珅
// Uri类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace internet_test3
{
    class UriTest
    {
        static void Main(string[] args)
        {
            // Uri
            Uri sample = new Uri("http://HerbSchildt.com/somefile.txt?SomeQuery");

            Console.WriteLine("Host: " + sample.Host);
            Console.WriteLine("Port " + sample.Port);
            Console.WriteLine("Scheme: " + sample.Scheme);
            Console.WriteLine("Local Path: " + sample.LocalPath);
            Console.WriteLine("Query: " + sample.Query);
        }
    }
}
