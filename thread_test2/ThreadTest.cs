// Copyright 2016.刘珅珅
// author：刘珅珅
// 确定线程停止
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test2
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

            // 构造3个线程
            MyThread thread1 = new MyThread("Child #1");
            MyThread thread2 = new MyThread("Child #2");
            MyThread thread3 = new MyThread("Child #3");

            // IsAlive只读属性判断线程是否停止
            do {
                Console.Write(".");
                Thread.Sleep(100);
            } while (thread1.thread.IsAlive 
                && thread2.thread.IsAlive
                && thread3.thread.IsAlive);

            Console.WriteLine("Main thread ending.");
        }
    }
}
