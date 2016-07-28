// Copyright 2016.刘珅珅
// author：刘珅珅
// unsafe使用：指针
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test1
{
    class Test
    {
        public int num;
        public Test(int i) { num = i; }
    }

    class PointerTest
    {
        // 不安全代码段
        unsafe static void Main(string[] args)
        {
            Test obj = new Test(19);

            // fixed防止垃圾回收器移动obj.num
            // 直到fixed代码段结束
            fixed (int* p = &obj.num)
            {
                Console.WriteLine("Initial vale of num is " + obj.num);

                *p = 10;

                Console.WriteLine("New value of num is " + obj.num);
            }
        }
    }
}
