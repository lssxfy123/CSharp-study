// Copyright 2016.刘珅珅
// author：刘珅珅
// 任务并行
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test1
{
    class MyClass
    {
        public void MyTask()
        {
            Console.WriteLine("MyTask() starting");

            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask(), count is " + i);
            }

            Console.WriteLine("MyTask terminating.");
        }
    }

    class TaskTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            MyClass obj = new MyClass();

            Task task = new Task(obj.MyTask);

            // 运行任务
            task.Start();

            for (int i = 0; i < 60; ++i)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread ending.");
        }
    }
}
