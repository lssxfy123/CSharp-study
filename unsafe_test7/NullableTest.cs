// Copyright 2016.刘珅珅
// author：刘珅珅
// 可空类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test7
{
    class NullableTest
    {
        static void Main(string[] args)
        {
            // 两种初始化方式相同
            System.Nullable<int> count = null;
            int? count1 = null;

            if (count.HasValue)
            {
                Console.WriteLine("count has this value: " + count.Value);
            }
            else
            {
                Console.WriteLine("count has no value.");
            }

            count = 100;

            if (count.HasValue)
            {
                Console.WriteLine("count has this value: " + count.Value);
            }
            else
            {
                Console.WriteLine("count has no value.");
            }
        }
    }
}
