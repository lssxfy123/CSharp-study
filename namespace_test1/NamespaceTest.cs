// Copyright 2016.刘珅珅
// author：刘珅珅
// 命名空间测试
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 使用自定义的命名空间
using Counter;

// 在命名空间Counter2中有和Counter相同的类
// 所以不能再使用using指示符
// using Counter2;  // error
using MyCounter = Counter2.CountDown;

namespace namespace_test1
{
    class NamespaceTest
    {
        static void Main(string[] args)
        {
            CountDown cd = new CountDown(10);
            int i;
            do {
                i = cd.Count();
                Console.Write(i + " ");
            } while (i > 0);

            Console.WriteLine();

            MyCounter cd2 = new MyCounter();
            cd2.Count();
        }
    }
}
