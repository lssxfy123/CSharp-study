// Copyright 2016.刘珅珅
// author：刘珅珅
// 与.NET兼容的事件处理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test3
{
    class MyEventArgs : EventArgs
    {
        public int EventNumber;
    }

    delegate void MyEventHandler(object sender, MyEventArgs e);

    class MyEvent
    {
        static int count = 0;

        // 声明一个事件
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            MyEventArgs arg = new MyEventArgs();

            if (SomeEvent != null)
            {
                arg.EventNumber = count++;
                SomeEvent(this, arg);
            }
        }
    }

    class X
    {
        public void Handler(object sender, MyEventArgs e)
        {
            Console.WriteLine("Event " + e.EventNumber 
                                            + " received by an X object.");
            Console.WriteLine("Source is " + sender);
            Console.WriteLine();
        }
    }

    class EventTest
    {
        static void Main(string[] args)
        {
            X obj = new X();
            MyEvent evt = new MyEvent();

            evt.SomeEvent += obj.Handler;

            evt.OnSomeEvent();
        }
    }
}
