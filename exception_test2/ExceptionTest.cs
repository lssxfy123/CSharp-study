// Copyright 2016.刘珅珅
// author：刘珅珅
// 异常处理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_test2
{
    class ExceptionTest
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 8, 16, 32, 64, 128, 256, 512};
            int[] denom = { 2, 0, 4, 4, 0, 8 };

            for (int i = 0; i < nums.Length; ++i)
            {
                try
                {
                    Console.WriteLine(nums[i] + " / "
                                                    + denom[i] + " is " 
                                                    + nums[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by Zero!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("No matching element found.");
                }
            }
        }
    }
}
