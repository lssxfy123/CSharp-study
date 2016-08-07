// Copyright 2016.刘珅珅
// author：刘珅珅
// 有序的PLNQ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_test9
{
    class TaskTest
    {
        static void Main(string[] args)
        {
            int[] data = new int[10000000];
            for (int i = 0; i < data.Length; ++i)
                data[i] = i;

            data[1000] = -2;
            data[14000] = -1;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            // 使用PLNQ查询负值
            // 有序查询，反映源序列的顺序
            var negatives = from val in data.AsParallel().AsOrdered()
                            where val < 0
                            select val;

            // 执行PLNQ查询
            //查找的结果顺序与源数据
            // 中的顺序一致
            foreach (var v in negatives)
                Console.Write(v + " ");

            Console.WriteLine();
        }
    }
}
