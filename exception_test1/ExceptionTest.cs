// Copyright 2016.刘珅珅
// author：刘珅珅
// 异常处理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_test1
{
    class ExceptionTest
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            try
            {
                Console.WriteLine("Before exception is generated.");
                for (int i = 0; i < 10; i ++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}] : {1}", i, nums[i]);
                }

                Console.WriteLine("This won't be displayed.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out-out-bound.");
            }
        }
    }
}
