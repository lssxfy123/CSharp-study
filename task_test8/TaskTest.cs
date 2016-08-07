// Copyright 2016.刘珅珅
// author：刘珅珅
// PLINQ：并行查询
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_test8
{
    class TaskTest
    {
        static void Main(string[] args)
        {
            int[] data = new int[10000000];
            for (int i = 0; i < data.Length; ++i)
                data[i] = i;

            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            // 使用PLNQ查询负值
            var negatives = from val in data.AsParallel()
                            where val < 0
                            select val;

            // 执行PLNQ查询
            // 每次执行查询，得到的结果的顺序不尽相同
            // 并行查询，任务负载，可以的处理器不同，
            // 会导致结果的顺序不同
            foreach (var v in negatives)
                Console.Write(v + " ");

            Console.WriteLine();
        }
    }
}
