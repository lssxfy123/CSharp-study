// Copyright 2016.刘珅珅
// author：刘珅珅
// 线程池
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace treadpool_test1
{
    class ThreadPoolTest
    {
        static void PooledFunc(object state)
        {
            Console.WriteLine("Processing request '{0}' " + "Is pool thread: {1}, Hash: {2}", (string)state, 
                Thread.CurrentThread.IsThreadPoolThread, Thread.CurrentThread.GetHashCode());

            // Thread.Sleep(2000);
            int ticks = Environment.TickCount;
            while (Environment.TickCount - ticks < 2000) ;
            Console.WriteLine("Request processed.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread. Is pool thread: {0}, Hash: {1}", 
                Thread.CurrentThread.IsThreadPoolThread, Thread.CurrentThread.GetHashCode());

            // 线程池
            WaitCallback call_back1 = new WaitCallback(PooledFunc);

            ThreadPool.QueueUserWorkItem(call_back1, "Is there any screw left?");

            ThreadPool.QueueUserWorkItem(call_back1, "How much is a 4w bulb?");

            ThreadPool.QueueUserWorkItem(call_back1, "Decrease stock of monkey wrench");

            Console.ReadLine();
        }
    }
}
