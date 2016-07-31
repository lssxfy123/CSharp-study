// Copyright 2016.刘珅珅
// author：刘珅珅
// 线程的优先级
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test5
{
    class MyThread
    {
        public int count;
        public Thread thread;

        static bool stop = false;
        static string current_name;

        public MyThread(string name)
        {
            count = 0;
            thread = new Thread(this.Run);
            thread.Name = name;
            current_name = name;
        }

        void Run()
        {
            Console.WriteLine(thread.Name + " starting.");

            do {
                ++count;

                if (current_name != thread.Name)
                {
                    current_name = thread.Name;
                    // Console.WriteLine("In " + current_name);
                }
            } while (stop == false && count < 1000000000);
            stop = true;

            Console.WriteLine(thread.Name + " terminating.");
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            MyThread thread1 = new MyThread("High Priority");
            MyThread thread2 = new MyThread("Low Priority");

             // 设置优先级
            thread1.thread.Priority = ThreadPriority.Highest;
            thread2.thread.Priority = ThreadPriority.Lowest;

            thread1.thread.Start();
            thread2.thread.Start();

            thread1.thread.Join();
            thread2.thread.Join();

            Console.WriteLine();

            Console.WriteLine(thread1.thread.Name + " thread counted to " 
                                             + thread1.count);

            Console.WriteLine(thread2.thread.Name + " thread counted to " 
                                             + thread2.count);
        }
    }
}
