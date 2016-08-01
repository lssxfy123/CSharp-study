// Copyright 2016.刘珅珅
// author：刘珅珅
// 任务的等待
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test3
{
    class TaskTestcs
    {
        // 任务函数
        static void MyTask()
        {
            Console.WriteLine("MyTask() #" + Task.CurrentId + " starting.");

            for (int i = 0; i < 5; ++i)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask() #" + Task.CurrentId + ", count is " + i);
            }

            Console.WriteLine("MyTask #" + Task.CurrentId + " terminating");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            Task task1 = new Task(MyTask);
            Task task2 = new Task(MyTask);

            // 运行任务
            task1.Start();
            task2.Start();

            Console.WriteLine("Task ID for task1 is " + task1.Id);
            Console.WriteLine("Task ID for task2 is " + task2.Id);

            // 暂停Main()直到task1和task2完成
            task1.Wait();
            task2.Wait();

            Console.WriteLine("Main thread ending.");
        }
    }
}
