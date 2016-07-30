// Copyright 2016.刘珅珅
// author：刘珅珅
// Join方法判断线程是否停止
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test3
{
    class MyThread
    {
        public int count;
        public Thread thread;

        public MyThread(string name)
        {
            count = 0;
            thread = new Thread(this.RunTest);
            thread.Name = name;
            thread.Start();
        }

        // 线程入口函数
        void RunTest()
        {
            Console.WriteLine(thread.Name + " starting.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + thread.Name + ", Count is " + count);
                ++count;
            } while (count < 10);
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            MyThread thread1 = new MyThread("Child #1");
            MyThread thread2 = new MyThread("Child #2");
            MyThread thread3 = new MyThread("Child #3");

            // Join()函数判断线程是否停止
            thread1.thread.Join();
            Console.WriteLine("Child #1 joined.");

            thread2.thread.Join();
            Console.WriteLine("Child #2 joined.");

            thread3.thread.Join();
            Console.WriteLine("Child #3 joined.");

            Console.WriteLine("Main thread ending.");
        }
    }
}
