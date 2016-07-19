// Copyright 2016.刘珅珅
// author：刘珅珅
// foreach循环用于数组
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_array_test1
{
    class ForeachArrayTest
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] nums = new int[3, 5];
            for (int i = 0; i < nums.GetLength(0); ++i)
            {
                for (int j = 0; j < nums.GetLength(1); ++j)
                {
                    nums[i, j] = (i + 1) * (j + 1);
                }
            }

            foreach (int x in nums)
            {
                Console.WriteLine("value is : " + x);
                sum += x;
            }
            Console.WriteLine("Sum is : " + sum);
        }
    }
}
