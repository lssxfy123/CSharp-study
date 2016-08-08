// Copyright 2016.刘珅珅
// author：刘珅珅
// BitArray：位存储
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test7
{
    class BitArrayTest
    {
        static void ShowBits(string rem, BitArray bits)
        {
            Console.WriteLine(rem);
            for (int i = 0; i < bits.Count; ++i)
                Console.Write("{0, -6}", bits[i]);
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(8);
            byte[] b = { 67};
            BitArray ba2 = new BitArray(b);

            ShowBits("Original contents of ba1: ", ba1);
            ba1 = ba1.Not();
            ShowBits("Contents of ba1 after Not:", ba1);

            // 67的二进制补码为：01000011
            // 输出为True True False False False False True False
            // 从低位开始输出
            ShowBits("Contents of ba2:", ba2);
        }
    }
}
