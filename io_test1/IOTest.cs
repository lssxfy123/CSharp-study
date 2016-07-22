// Copyright 2016.刘珅珅
// author：刘珅珅
// I/O测试：控制台输入
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_test1
{
    class IOTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some characters.");
            string str = Console.ReadLine();
            Console.WriteLine("You entered: " + str);
        }
    }
}
