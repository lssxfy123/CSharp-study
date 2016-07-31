// Copyright 2016.刘珅珅
// author：刘珅珅
// 实现同步的另一种方式
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_test7
{
    class SumArray
    {
        int sum;

        public int SumIt(int[] nums)
        {
            sum = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];

                Console.WriteLine("Running total for " + Thread.CurrentThread.Name
                                                 + " is " + sum);
                Thread.Sleep(10);
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

            // 直接在MyThread类中锁定SumArray的SumIt()方法
            // sa为私有变量，可以安全的锁定
            lock (sa)
            {
                answer = sa.SumIt(array);
            }
            
            Console.WriteLine("Sum for " + thread.Name + " is " + answer);

            Console.WriteLine(thread.Name + " terminating.");
        }
    }

    class ThreadTest
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            MyThread thread1 = new MyThread("Child #1", array);
            MyThread thread2 = new MyThread("Child #2", array);

            thread1.thread.Join();
            thread2.thread.Join();
        }
    }
}
