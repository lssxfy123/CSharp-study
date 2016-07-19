// Copyright 2016.刘珅珅
// author：刘珅珅
// 取模运算符%的测试
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_operator_test1
{
    class ModOperatorTest
    {
        static void Main()
        {
            int iresult, irem;
            double dresult, drem;

            iresult = 10 / 3;
            irem = 10 % 3;

            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;

            Console.WriteLine("Result and remainder of 10 / 3: " + iresult  + " " + irem);
            Console.WriteLine("Result and remainder of 10.0 / 3.0: " + dresult + " " + drem);
        }
    }
}
