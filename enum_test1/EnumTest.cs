// Copyright 2016.刘珅珅
// author：刘珅珅
// 枚举
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_test1
{
    class EnumTest
    {
        enum Apple
        {
            Jonthan,
            GoldDel,
            RedDel,
            Cortland,
            McIntosh
        };

        static void Main(string[] args)
        {
            string[] color = { "Red", "Yellow", "Red", "Red", "Reddish Green" };

            for (Apple i = Apple.Jonthan; i <= Apple.McIntosh; ++i)
            {
                Console.WriteLine(i + " has value of " + (int)i);
            }

            for (Apple i = Apple.Jonthan; i<= Apple.McIntosh; ++i)
            {
                Console.WriteLine("Color of " + i + " is " + color[(int)i]);
            }
        }
    }
}
