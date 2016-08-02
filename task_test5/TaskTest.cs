// Copyright 2016.刘珅珅
// author：刘珅珅
// 任务延续
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test5
{
    class TaskTest
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() starting.");

            for (int i = 0; i < 5; ++i)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask() count is " + i);
            }

            Console.WriteLine("MyTask terminating.");
        }

        // 延续任务入口点方法
        static void ContTask(Task t)
        {
            Console.WriteLine("Continuation starting.");

            for (int i = 0; i < 5; ++i)
            {
                Thread.Sleep(500);
                Console.WriteLine("Continuation count is " + i);
            }

            Console.WriteLine("Continuation terminating.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            // 起始任务
            Task task = new Task(MyTask);

            // 延续任务
            Task taskCont = task.ContinueWith(ContTask);

            task.Start();

            // 延续任务等待
            // 起始任务不需要等待
            // 它肯定在延续任务结束之前结束
            taskCont.Wait();

            task.Dispose();
            taskCont.Dispose();

            Console.WriteLine("Main thread ending.");
        }
    }
}
