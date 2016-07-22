// Copyright 2016.刘珅珅
// author：刘珅珅
// 事件
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test1
{
    delegate void MyEventHandler();

    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
            {
                SomeEvent();
            }
        }
    }

    class EventTest
    {
        // 事件处理程序，需要与事件的委托匹配
        static void Handler()
        {
            Console.WriteLine("Event occurred.");
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

             // 添加事件处理程序到事件链表
            evt.SomeEvent += Handler;

            // 触发事件
            evt.OnSomeEvent();
        }
    }
}
