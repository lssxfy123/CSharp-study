// Copyright 2016.刘珅珅
// author：刘珅珅
// Interlocked同步
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test12
{
    class SharedRes
    {
        public static int count = 0;
    }

    class IncThread
    {
        public Thread thread;

        public IncThread(string name)
        {
            thread = new Thread(this.Run);
            thread.Name = name;
            thread.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; ++i)
            {
                Interlocked.Increment(ref SharedRes.count);
                Console.WriteLine(thread.Name + " count is " + SharedRes.count);
            }
        }
    }

    class DecThread
    {
        public Thread thread;

        public DecThread(string name)
        {
            thread = new Thread(this.Run);
            thread.Name = name;
            thread.Start();
        }


        void Run()
        {
            for (int i = 0; i < 5; ++i)
            {
                Interlocked.Decrement(ref SharedRes.count);
                Console.WriteLine(thread.Name + " count is " + SharedRes.count);
            }

        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            IncThread thread1 = new IncThread("Increment Thread");
            DecThread thread2 = new DecThread("Decrement Thread");

            thread1.thread.Join();
            thread2.thread.Join();
        }
    }
}
