// Copyright 2016.刘珅珅
// author：刘珅珅
// 任务返回值
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test6
{
    class TaskTest
    {
        // 任务方法：返回bool值
        static bool MyTask()
        {
            Console.WriteLine("Task starting.");
            Thread.Sleep(2000);
            Console.WriteLine("Task terminating.");
            return true;
        }

        // 任务方法：带有参数，返回int
        static int SumIt(object v)
        {
            int x = (int)v;
            int sum = 0;

            for (; x > 0; --x)
                sum += x;

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            Task<bool> task = Task<bool>.Factory.StartNew(MyTask);

            // 检索任务的返回结果，主线程会阻塞，直到任务运行完毕并返回结果
            // 如果不检索任务的返回结果，则主线程不会阻塞，任务有可能不会执行完
            Console.WriteLine("After running MyTask. The result is " + task.Result);

            Task<int> task2 = Task<int>.Factory.StartNew(SumIt, 5);

            Console.WriteLine("After running SumIt. The result is " + task2.Result);

            // 如果不检索结果就调用Dispose()方法，
            // 有可能会抛出异常，因为任务没有执行完毕
            task.Dispose();
            task2.Dispose();
            Console.WriteLine("Main thread terminating.");
        }
    }
}
