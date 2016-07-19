// Copyright 2016.刘珅珅
// author：刘珅珅
// 按位显示
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bit_show_test1
{
    class BitShowTest
    {
        static void Main()
        {
            byte val = 123;
            for (int t = 128; t > 0; t = t / 2)  // 显示8位
            {
                if ((val & t) != 0)
                {
                    Console.Write("1 ");
                }

                if ((val & t) == 0)
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
        }
    }
}
