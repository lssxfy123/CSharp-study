// Copyright 2016.刘珅珅
// author：刘珅珅
// 多播委托事件
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test2
{
    delegate void MyEventHandler();

    class MyEvent
    {
        // 声明事件
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
            {
                SomeEvent();
            }
        }
    }

    class X
    {
        public void Xhandler()
        {
            Console.WriteLine("Event received by X object.");
        }
    }

    class Y
    {
        public void Yhandler()
        {
            Console.WriteLine("Event received by Y object.");
        }
    }

    class EventTest
    {
        static void Handler()
        {
            Console.WriteLine("Event received by Test.");
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            X obj_x = new X();
            Y obj_y = new Y();

            // 多播委托的事件
            evt.SomeEvent += Handler;
            evt.SomeEvent += obj_x.Xhandler;
            evt.SomeEvent += obj_y.Yhandler;

            evt.OnSomeEvent();
        }
    }
}
