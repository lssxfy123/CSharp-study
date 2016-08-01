// Copyright 2016.刘珅珅
// author：刘珅珅
// TaskFactory与Lambda表达式
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test4
{
    class TaskTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            // 使用TaskFactory任务工厂启动任务
            // 使用Lambda表达式定义一个任务入口方法
            Task task = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task starting.");

                for (int i = 0; i < 10; ++i)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Task count is " + i);
                }

                Console.WriteLine("Task terminating");
            });

            // 等待直到任务完成
            task.Wait();

            // 任务的清除
            // Dispose()方法必须在Wait()或类似的表示
            // 任务完成的方法调用完成之后才能调用
            // Dispose()方法主要用于创建并放弃许多任务的程序
            task.Dispose();

            Console.WriteLine("Main thread ending.");
        }
    }
}
