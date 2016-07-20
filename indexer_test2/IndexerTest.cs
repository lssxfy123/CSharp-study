// Copyright 2016.刘珅珅
// author：刘珅珅
// 索引器
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_test2
{
    // 2的0-15次幂
    class PowerOfTwo
    {
        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < 16))
                {
                    return power(index);
                }
                else
                {
                    return -1;
                }
            }
        }

        int power(int p)
        {
            int result = 1;
            for (int i = 0; i < p; ++i)
            {
                result *= 2;
            }

            return result;
        }
    }

    class IndexerTest
    {
        static void Main(string[] args)
        {
            PowerOfTwo pwr = new PowerOfTwo();

            Console.Write("First 8 powers of 2: ");
            for (int i = 0; i < 8; ++i)
            {
                Console.Write(pwr[i] + " ");  // 使用索引器
            }

            Console.WriteLine();
            Console.Write("Here are some errors: ");
            Console.Write(pwr[-1] + " " + pwr[17]);
            Console.WriteLine();
        }
    }
}
