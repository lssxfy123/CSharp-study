// Copyright 2016.刘珅珅
// author：刘珅珅
// 可变参数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_test1
{
    class Min
    {
        public int MinValue(params int[] nums)
        {
            int min_value;
            if (nums.Length == 0)
            {
                Console.WriteLine("Error: no arguments");
                return 0;
            }
            min_value = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] < min_value)
                {
                    min_value = nums[i];
                }
            }
            return min_value;
        }
    }

    class MyClass
    {
        public void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + ": ");

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }

    class ParamsTest
    {
        static void Main(string[] args)
        {
            Min obj = new Min();
            int min_value;

            min_value = obj.MinValue(10, 20, 30);
            Console.WriteLine("Minimum is " + min_value);

            min_value = obj.MinValue(10, 20, 30, -1);
            Console.WriteLine("Minimum is " + min_value);

            MyClass obj1 = new MyClass();
            obj1.ShowArgs("Here are some integers", 1, 2, 3, 4, 5);
            obj1.ShowArgs("Here are two more", 17, 20);
        }
    }
}
