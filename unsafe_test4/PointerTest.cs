// Copyright 2016.刘珅珅
// author：刘珅珅
// 指针访问数组
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test4
{
    class PointerTest
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            string str = "this is a test.";

            unsafe
            {
                // 访问数组
                fixed (int* n_ptr = nums)
                {
                    for (int i = 0; i < 10; ++i)
                    {
                        n_ptr[i] = i;
                    }

                    for (int i = 0; i < 10; ++i)
                        Console.WriteLine("n_ptr[{0}] : {1}", i, n_ptr[i]);
                }

                Console.WriteLine();

                fixed (int* n_ptr = nums)
                {
                    for (int i = 0; i < 10; ++i)
                    {
                        *(n_ptr + i) = i;
                    }

                    for (int i = 0; i < 10; ++i)
                        Console.WriteLine("*(n_ptr + {0}) : {1}", i, *(n_ptr + i));
                }

                Console.WriteLine();

                // 访问字符串
                fixed (char* c_ptr = str)
                {
                    for (int i = 0; i < str.Length; ++i)
                    {
                        Console.Write(c_ptr[i]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
