// Copyright 2016.刘珅珅
// author：刘珅珅
// 互斥锁
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test9
{
    class SharedRes
    {
        public static int count = 0;
        public static Mutex mutex = new Mutex();
    }

    class IncThread
    {
        int num;
        public Thread thread;

        public IncThread(string name, int n)
        {
            thread = new Thread(this.Run);
            num = n;
            thread.Name = name;
            thread.Start();
        }

        void Run()
        {
            Console.WriteLine(thread.Name + " is waiting for the mutex.");

            // 请求Mutex
            SharedRes.mutex.WaitOne();

            Console.WriteLine(thread.Name + " acquires the mutex.");

            do
            {
                Thread.Sleep(500);
                SharedRes.count++;
                Console.WriteLine("In " + thread.Name 
                                                + ", SharedRes.count is " + SharedRes.count);
                --num;
            } while (num > 0);

            Console.WriteLine(thread.Name + " releases the mutex.");
            SharedRes.mutex.ReleaseMutex();
        }
    }

    class DecThread
    {
        int num;
        public Thread thread;

        public DecThread(string name, int n)
        {
            thread = new Thread(this.Run);
            num = n;
            thread.Name = name;
            thread.Start();
        }

        void Run()
        {
            Console.WriteLine(thread.Name + " is waiting for the mutex.");

            // 请求Mutex
            SharedRes.mutex.WaitOne();

            Console.WriteLine(thread.Name + " acquires the mutex.");

            do
            {
                Thread.Sleep(500);
                SharedRes.count--;
                Console.WriteLine("In " + thread.Name
                                                + ", SharedRes.count is " + SharedRes.count);
                --num;
            } while (num > 0);

            Console.WriteLine(thread.Name + " releases the mutex.");
            SharedRes.mutex.ReleaseMutex();
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            IncThread thread1 = new IncThread("Increment Thread", 5);

            // 使增加线程启动
            Thread.Sleep(1);

            DecThread thread2 = new DecThread("Decrement Thread", 5);

            thread1.thread.Join();
            thread2.thread.Join();
        }
    }
}
