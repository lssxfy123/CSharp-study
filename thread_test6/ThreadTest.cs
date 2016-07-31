// Copyright 2016.刘珅珅
// author：刘珅珅
// 多线程同步
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test6
{
    class SumArray
    {
        int sum;

        // 私有对象用于锁定
        object lock_obj = new object();

        public int SumIt(int[] nums)
        {
            // 锁定一个私有对象
            lock(lock_obj)
            {
                sum = 0;

                for (int i = 0; i < nums.Length; ++i)
                {
                    sum += nums[i];

                    Console.WriteLine("Running total for " + Thread.CurrentThread.Name 
                                                     + " is " + sum);
                    Thread.Sleep(10);
                }
            }
            return sum;
        }
    }

    class MyThread
    {
        public Thread thread;
        int[] array;
        int answer;

        // SumArray的静态对象
        // 所有的MyThread对象共享这个静态对象
        static SumArray sa = new SumArray();

        public MyThread(string name, int[] nums)
        {
            array = nums;
            thread = new Thread(this.Run);
            thread.Name = name;
            thread.Start();
        }

        void Run()
        {
            Console.WriteLine(thread.Name + " starting.");
            answer = sa.SumIt(array);

            Console.WriteLine("Sum for " + thread.Name + " is " + answer);

            Console.WriteLine(thread.Name + " terminating.");
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5};

            MyThread thread1 = new MyThread("Child #1", array);
            MyThread thread2 = new MyThread("Child #2", array);

            thread1.thread.Join();
            thread2.thread.Join();
        }
    }
}
