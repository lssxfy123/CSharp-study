// Copyright 2016.刘珅珅
// author：刘珅珅
// switch-case语句
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_test1
{
    class SwitchTest
    {
        static void Main(string[] args)
        {
            int i = 0;
            switch  (i)
            {
                case 0:
                    Console.WriteLine("i is " + 0);
                    break;  // 必须有break，在C++中未必有
                case 1:
                case 2:
                    Console.WriteLine("i is " + 1 + " or " + 2);
                    break;  // 必须有break
                default:
                    break;
            }

            string str = "ab";
            switch (str)  // switch变量可以是字符串
            {
                case "ab":
                    Console.WriteLine("str is " + str);
                    break;
                default:
                    break;
            }
        }
    }
}
