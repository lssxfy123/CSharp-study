// Copyright 2016.刘珅珅
// author：刘珅珅
// 信号量
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test10
{
    class MyThread
    {
        public Thread thread;

        // 信号量许可证的初始值为2，最大值也为2
        // 最多允许两个线程同时访问它
        static Semaphore sem = new Semaphore(2, 2);

        public MyThread(string name)
        {
            thread = new Thread(this.Run);
            thread.Name = name;
            thread.Start();
        }

        void Run()
        {
            Console.WriteLine(thread.Name + " is waiting for a permit");

            // 等待获取许可证
            sem.WaitOne();

            Console.WriteLine(thread.Name + " acquires a permit.");

            for (char ch = 'A'; ch < 'D'; ++ch)
            {
                Console.WriteLine(thread.Name + " : " + ch + " ");
                Thread.Sleep(500);
            }

            Console.WriteLine(thread.Name + " release a permit.");

            // 释放许可证
            sem.Release();
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            MyThread thread1 = new MyThread("Thread #1");
            MyThread thread2 = new MyThread("Thread #2");
            MyThread thread3 = new MyThread("Thread #3");

            thread1.thread.Join();
            thread1.thread.Join();
            thread3.thread.Join();
        }
    }
}
