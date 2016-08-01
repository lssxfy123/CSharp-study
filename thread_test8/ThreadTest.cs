// Copyright 2016.刘珅珅
// author：刘珅珅
// 线程间的通信
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test8
{
    class TickTock
    {
        object lock_obj = new object();

        public void Tick(bool running)
        {
            lock(lock_obj)
            {
                if (!running)
                {
                    // 唤醒等待线程队列中的第一个线程
                    // 函数返回会自动释放锁
                    Monitor.Pulse(lock_obj);
                    return;
                }

                Console.Write("Tick");
                Monitor.Pulse(lock_obj);

                // 释放锁，并阻塞Tick()方法，直到
                // 重新锁定lock_obj对象
                Monitor.Wait(lock_obj);

                // Console.Write("end");
            }
        }

        public void Tock(bool running)
        {
            lock (lock_obj)
            {
                if (!running)
                {
                    // 通知等待线程队列中的第一个线程
                    Monitor.Pulse(lock_obj);
                    return;
                }

                Console.WriteLine("Tock");

                Monitor.Pulse(lock_obj);

                Monitor.Wait(lock_obj);
            }
        }
    }

    class MyThread
    {
        public Thread thread;
        TickTock obj;

        public MyThread(string name, TickTock tt)
        {
            thread = new Thread(this.Run);
            obj = tt;
            thread.Name = name;
            thread.Start();
        }

        void Run()
        {
            if (thread.Name == "Tick")
            {
                for (int i = 0; i < 5; ++i)
                    obj.Tick(true);

                obj.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; ++i)
                    obj.Tock(true);

                obj.Tock(false);
            }
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            TickTock tt = new TickTock();

            MyThread thread1 = new MyThread("Tick", tt);
            MyThread thread2 = new MyThread("Tock", tt);

            thread1.thread.Join();
            thread2.thread.Join();
            Console.WriteLine("Clock Stopped.");
        }
    }
}
