// Copyright 2016.刘珅珅
// author：刘珅珅
// 事件同步
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test11
{
    class MyThread
    {
        public Thread thread;
        ManualResetEvent mre;

        public MyThread(string name, ManualResetEvent evt)
        {
            thread = new Thread(this.Run);
            thread.Name = name;
            mre = evt;
            thread.Start();
        }

        void Run()
        {
            Console.WriteLine("Inside thread " + thread.Name);

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine(thread.Name);
                Thread.Sleep(500);
            }

            Console.WriteLine(thread.Name + " Done!");

            // 发送事件信号：将事件置成已发出信号状态
            mre.Set();
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            // false：初始状态下，事件未发出信号
            // true：初始状态下，事件已发出信号
            ManualResetEvent evt_obj = new ManualResetEvent(false);

            MyThread thread1 = new MyThread("Event Thread 1", evt_obj);

            Console.WriteLine("Main thread waiting for event.");

            // 等待事件发出信号
            evt_obj.WaitOne();

            Console.WriteLine("Main thread received first event.");

            // 复位事件信号
            evt_obj.Reset();
        }
    }
}
