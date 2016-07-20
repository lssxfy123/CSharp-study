// Copyright 2016.刘珅珅
// author：刘珅珅
// 索引器测试
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_test1
{
    class FailSoftArray
    {
        int[] a;
        public int Length;
        public bool error_flag;

        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }

        // 索引器
        public int this[int index]
        {
            get  // get存取器
            {
                if (Ok(index))
                {
                    error_flag = false;
                    return a[index];
                }
                else
                {
                    error_flag = true;
                    return 0;
                }
            }

            set  // set存取器
            {
                if (Ok(index))
                {
                    a[index] = value;
                    error_flag = false;
                }
                else
                {
                    error_flag = true;
                }
            }
        }

        private bool Ok(int index)
        {
            if (index >= 0 && index < Length)
            {
                return true;
            }
            return false;
        }
    }

    class IndexerTest
    {
        static void Main()
        {
            FailSoftArray fs = new FailSoftArray(5);

            for (int i = 0; i < (fs.Length * 2); ++i)
            {
                fs[i] = i + 1;  // 使用索引器
                if (fs.error_flag)
                {
                    Console.WriteLine("fs[" + i + "] out-of-bounds");
                }
            }

            for (int i = 0; i < (fs.Length * 2); ++i)
            {
                int x = fs[i];  // 使用索引器
                if (!fs.error_flag)
                {
                    Console.Write(x + " ");
                }
                else
                {
                    Console.WriteLine("fs[" + i + "] out-of-bounds");
                }
            }
        }
    }
}
