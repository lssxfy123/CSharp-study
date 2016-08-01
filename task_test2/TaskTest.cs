// Copyright 2016.刘珅珅
// author：刘珅珅
// 任务ID
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test2
{
    class TaskTest
    {
        // 任务函数
        static void MyTask()
        {
            Console.WriteLine("MyTask() #" + Task.CurrentId + " starting.");

            for (int i = 0; i < 10; ++i)
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

            task1.Start();
            task2.Start();

            Console.WriteLine("Task ID for task1 is " + task1.Id);
            Console.WriteLine("Task ID for task2 is " + task2.Id);

            // 任务执行期间，保持Main()运行不退出
            for (int i = 0; i < 60; ++i)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread ending.");
        }
    }
}
