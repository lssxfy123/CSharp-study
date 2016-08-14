// Copyright 2016.刘珅珅
// author：刘珅珅
// 并行集合：安全的用于多线程
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace collection_test12
{
    class BlockingCollectionTest
    {
        static BlockingCollection<char> blocking_collection;

        // 生产者：生产A-Z
        static void Producer()
        {
            for (char c = 'A'; c <= 'Z'; ++c)
            {
                blocking_collection.Add(c);
                Console.WriteLine("Producing " + c);
            }
            blocking_collection.CompleteAdding();
        }

        // 消费者
        static void Consumer()
        {
            char c;

            while (!blocking_collection.IsCompleted)
            {
                if (blocking_collection.TryTake(out c))
                    Console.WriteLine("Consuming " + c);
            }
        }

        static void Main(string[] args)
        {
            // 阻塞前，集合可存储的最大对象数为4
            blocking_collection = new BlockingCollection<char>(4);

            Task producer = new Task(Producer);
            Task consumer = new Task(Consumer);

            // 任务开始
            consumer.Start();
            producer.Start();
            

            try
            {
                Task.WaitAll(producer, consumer);
            } catch (AggregateException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                producer.Dispose();
                consumer.Dispose();
                blocking_collection.Dispose();
            }
        }
    }
}
