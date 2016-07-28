// Copyright 2016.刘珅珅
// author：刘珅珅
// dynamic类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_test2
{
    class DynamicTest
    {
        static void Main(string[] args)
        {
            dynamic obj;
            obj = "This is a test";
            obj = obj.ToUpper();
        }
    }
}
