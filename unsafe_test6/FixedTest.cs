// Copyright 2016.刘珅珅
// author：刘珅珅
// 固定缓冲区fixed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test6
{
    unsafe struct FixedBankRecord
    {
        int n;
        double b;
        char c;
        public fixed byte Name[80];
        public double Balance;
        public long ID;
    }

    class FixedTest
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // 结果为120
                // 与C++中结构体大小的计算比较类似
                // 需要填充字节
                Console.WriteLine("Size of FixedBankRecord is " + sizeof(FixedBankRecord));
            }
        }
    }
}
