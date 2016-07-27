// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ的简单使用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test1
{
    class LINQTest
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5};

            // 创建LINQ查询，但不产生结果
            var positive_nums = from n in nums 
                                              where n > 0 select n;
            Console.Write("The positive vlaues in nums: ");

            // 执行查询
            foreach (int i in positive_nums)
                Console.Write(i + " ");

            Console.WriteLine();

            Console.WriteLine("Setting nums[1] to 99");
            nums[1] = 99;

            Console.Write("The positive values in nums after change: ");

            // 再一次执行查询
            foreach (int i in positive_nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
