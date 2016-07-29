// Copyright 2016.刘珅珅
// author：刘珅珅
// Array中的sort排序
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_test3
{
    // 对于自定义类型，如果使用
    // Array.Sort方法需要实现IComparable接口
    class MyClass : IComparable<MyClass>
    {
        public int i;
        public MyClass(int x) { i = x; }
        public int CompareTo(MyClass v)
        {
            return i - v.i;
        }
    }

    class ArrayTest
    {
        static void Main(string[] args)
        {
            MyClass[] nums = new MyClass[5];
            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = new MyClass(5 - i);
            }

            Console.Write("Original order: ");
            foreach (MyClass item in nums)
                Console.Write(item.i + " ");

            Console.WriteLine();

            Array.Sort(nums);

            Console.Write("Sorted order: ");
            foreach (MyClass item in nums)
                Console.Write(item.i + " ");

            Console.WriteLine();
        }
    }
}
