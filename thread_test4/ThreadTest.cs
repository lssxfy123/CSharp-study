// Copyright 2016.刘珅珅
// author：刘珅珅
// 为线程传递实参
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test4
{
    class MyThread
    {
        public int count;
        public Thread thread;

        public MyThread(string name, int num)
        {
            count = 0;
            thread = new Thread(this.Run);
            thread.Name = name;

            // 传递实参给线程
            thread.Start(num);
        }

        void Run(object num)
        {
            Console.WriteLine(thread.Name + " starting with count of " + num);

            do {
                Thread.Sleep(500);
                Console.WriteLine("In " + thread.Name + ", Count is " + count);
                ++count;
            } while (count < (int)num);
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            MyThread thread1 = new MyThread("Child #1", 5);
            MyThread thread2 = new MyThread("Child #2", 3);

            do {
                Thread.Sleep(100);
            } while (thread1.thread.IsAlive | thread2.thread.IsAlive);

            Console.WriteLine("Main thread ending.");
        }
    }
}
