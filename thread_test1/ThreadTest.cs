// Copyright 2016.刘珅珅
// author：刘珅珅
// 多线程编程
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test1
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

            do {
                Thread.Sleep(500);
                Console.WriteLine("In " + thread.Name + ", Count is " + count);
                ++count;
            } while(count < 10);
        }
    }


    class ThreadTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            MyThread thread = new MyThread("Child #1");

            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (thread.count != 10);

            Console.WriteLine("Main thread ending.");
        }
    }
}
