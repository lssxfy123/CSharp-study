// Copyright 2016.刘珅珅
// author：刘珅珅
// 并行方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_test7
{
    class TaskTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            // Invoke()将启动传递给它的所有方法，
            // 并等待所有方法完成。不需要Wait()这样的方法
            // 也无法保证方法执行的顺序
            // 使用语句Lambda传递方法
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Expression #1 starting.");
                for (int i = 0; i < 5; ++i)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Expression #1 count is " + i);
                }

                Console.WriteLine("Expression #1 terminating.");
            },
            () => {
                Console.WriteLine("Expression #2 starting.");
                for (int i = 0; i < 5; ++i)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Expression #2 count is " + i);
                }

                Console.WriteLine("Expression #2 terminating.");
            }
            );

            Console.WriteLine("Main thread ending.");
        }
    }
}
