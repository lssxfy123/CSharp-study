// Copyright 2016.刘珅珅
// author：刘珅珅
// 命名空间合成
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Counter;

namespace Counter
{
    class CountDown
    {
        public void Count()
        {
            Console.WriteLine("CountDown::Count()");
        }
    }
}

namespace Counter
{
    class CountUp
    {
        public void Count()
        {
            Console.WriteLine("CountUp::Count()");
        }
    }
}



namespace namespact_test2
{
    class NamespaceTest
    {
        static void Main(string[] args)
        {
            CountDown cd = new CountDown();
            CountUp cp = new CountUp();

            cd .Count();
            cp.Count();
        }
    }
}
