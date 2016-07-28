// Copyright 2016.刘珅珅
// author：刘珅珅
// sizeof和stackalloc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test5
{
    class PointerTest
    {
        static void Main(string[] args)
        {
            int n = 2;
            double d = 8.5;

            unsafe
            {
                int* n_ptr = &n;

                Console.WriteLine("n_ptr size " + sizeof(int*));  // 4

                double* d_ptr = &d;
                Console.WriteLine("d_ptr size " + sizeof(double*));  // 4
            }

            Console.WriteLine();

            unsafe
            {
                // stackalloc有点类似C++中的new
                int* ptrs = stackalloc int[3];
                ptrs[0] = 1;
                ptrs[1] = 2;
                ptrs[2] = 3;

                for (int i = 0; i < 3; ++i )
                    Console.WriteLine(ptrs[i]);
            }
        }
    }
}
