// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ:select子句
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test4
{
    class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public EmailAddress(string n, string a)
        {
            Name = n;
            Address = a;
        }
    }

    class LINQTest
    {
        static void Main(string[] args)
        {
            double[] nums = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5};

            // 数组中大于0的项的平方根
            // select子句对范围变量进行操作
            var sqrt_roots = from n in nums
                             where n > 0
                             select Math.Sqrt(n);

            Console.WriteLine("The square roots of the positive values" 
                                             + " rounded to two decimal places: ");

            // 执行查询
            foreach (double r in sqrt_roots)
                Console.WriteLine("{0:#.##}", r);

            Console.WriteLine();

            EmailAddress[] addrs = {
                                       new EmailAddress("Herb", "Herb@HerbSchildt.com"),
                                       new EmailAddress("Tom", "Tom@HerbSchildt.com"),
                                       new EmailAddress("Sara", "Sara@Herbschildt.com")
                                   };

            // select子句返回范围变量的部分信息
            var email_addrs = from entry in addrs
                              select entry.Address;

            Console.WriteLine("The email addresses are");

            // 执行查询
            foreach (var s in email_addrs)
                Console.WriteLine(" " + s);

        }
    }
}
