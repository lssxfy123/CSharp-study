// Copyright 2016.刘珅珅
// author：刘珅珅
// Queue：队列
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test6
{
    class QueueTest
    {
        static void ShowEnq(Queue q, int a)
        {
            q.Enqueue(a);
            Console.WriteLine("Enqueue(" + a + ")");

            Console.Write("queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
        }

        static void ShowDeq(Queue q)
        {
            Console.Write("Dequeue -> ");
            int a = (int)q.Dequeue();
            Console.WriteLine(a);

            Console.Write("queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Queue q = new Queue();

            ShowEnq(q, 22);
            ShowEnq(q, 33);
            ShowEnq(q, 44);
            ShowDeq(q);
            ShowDeq(q);
            ShowDeq(q);

            try
            {
                ShowDeq(q);
            } catch (InvalidOperationException)
            {
                Console.WriteLine("Queue empty.");
            }
        }
    }
}
