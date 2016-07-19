using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_test2
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[10];
            int[] nums2 = new int[] { -1, -2, -3, -4, - 5, -6, -7, -8, -9, -10};

            for (int i = 0; i < 10; ++i)
            {
                nums1[i] = i + 1;
            }

            Console.Write("nums1 is : ");
            //  1 2 3 4 5 6 7 8 9 10
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(nums1[i] + " ");
            }

            Console.WriteLine();
            Console.Write("nums2 is : ");
            // -1 -2 -3 -4 -5 -6 -7 -8 -9 -10
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(nums2[i] + " ");
            }
            Console.WriteLine();

            nums2 = nums1;  // C#中允许这样赋值

            Console.Write("nums1 is : ");
            //  1 2 3 4 5 6 7 8 9 10
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(nums1[i] + " ");
            }

            Console.WriteLine();
            Console.Write("nums2 is : ");
            //  1 2 3 4 5 6 7 8 9 10
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(nums2[i] + " ");
            }

            Console.WriteLine();

            nums2[3] = 99;
            Console.Write("nums1 is : ");
            //  1 2 3 99 5 6 7 8 9 10
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(nums1[i] + " ");
            }

            Console.WriteLine();
            Console.Write("nums2 is : ");
            //  1 2 3 99 5 6 7 8 9 10
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(nums2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
