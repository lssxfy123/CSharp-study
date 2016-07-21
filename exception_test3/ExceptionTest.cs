// Copyright 2016.刘珅珅
// author：刘珅珅
// 异常处理try-catch-finally
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_test3
{
    class UseFinally
    {
        public static void GenException(int what)
        {
            int t;
            int[] nums = new int[2];

            Console.WriteLine("Receiving " + what);
            try
            {
                switch (what)
                {
                    case 0:
                        t = 10;
                        break;
                    case 1:
                        nums[4] = 4;
                        break;
                    case 2:
                        return;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by Zero!");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No matching element found.");
            }
            finally
            {
                Console.WriteLine("Leaving try.");
            }
        }
    }

    class ExceptionTest
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; ++i)
            {
                UseFinally.GenException(i);
                Console.WriteLine();
            }
        }
    }
}
