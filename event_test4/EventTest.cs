// Copyright 2016.刘珅珅
// author：刘珅珅
// 使用EventHandler委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test4
{
    class MyEvent
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
            {
                SomeEvent(this, EventArgs.Empty);
            }
        }
    }

    class EventTest
    {
        static void Handler(object sender, EventArgs e)
        {
            Console.WriteLine("Event occurred.");
            Console.WriteLine("Source is " + sender);
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            // 注册事件处理程序到事件链表
            evt.SomeEvent += Handler;

            evt.OnSomeEvent();
        }
    }
}
