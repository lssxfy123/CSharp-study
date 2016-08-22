// Copyright 2016.刘珅珅
// author：刘珅珅
// Observer模式
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_test1
{
    // 定义事件参数
    internal class CheckListEventArgs:EventArgs
    {
        private readonly string check_list;

        public CheckListEventArgs(string check_list)
        {
            this.check_list = check_list;
        }

        public string CheckList
        {
            get { return check_list; }
        }
    }

    internal delegate void PublishEventHandler(object sender, CheckListEventArgs args);

    // 发布者基类
    internal class Subject
    {
        public event PublishEventHandler PublishCheckListEvent;
        
        // 通知所有订阅者
        public void Notify(CheckListEventArgs args)
        {
            if (PublishCheckListEvent != null)
                PublishCheckListEvent(this, args);
        }
    }

    // 订阅者基类
    internal abstract class Observer
    {
        public abstract void Received(object sender, CheckListEventArgs args);
    }

    // 发布者具体类
    class Moblie : Subject
    {
        public void SimulateCheckList()
        {
            Console.WriteLine("--------话费清单-------");
            CheckListEventArgs args = new CheckListEventArgs("市话话费12\t\t长途话费20\n");
            base.Notify(args);
        }
    }

    // 订阅者具体类
    class Jerry:Observer
    {
        public override void Received(object sender, CheckListEventArgs args)
        {
            Console.WriteLine("Jerry收到话费通知:\n{0}", args.CheckList);
        }
    }

    // 另一个订阅者
    class Anco:Observer
    {
        public void Subscribe(Subject obj)
        {
            obj.PublishCheckListEvent += Received;
        }

        public void Unsubscribe(Subject obj)
        {
            obj.PublishCheckListEvent -= Received;
        }

        public override void Received(object sender, CheckListEventArgs args)
        {
            Console.WriteLine("Anco收到话费通知:\n{0}", args.CheckList);
        }
    }
    class ObserverTest
    {
        static void Main(string[] args)
        {
            Moblie mobile = new Moblie();
            Jerry jerry = new Jerry();
            Anco anco = new Anco();

            // 订阅
            mobile.PublishCheckListEvent += jerry.Received;

            // 订阅
            anco.Subscribe(mobile);

            // 从结果可以看出，同一个对象
            // 同一个事件多次注册了同一个处理函数
            // 当事件触发时，也会执行多次
            anco.Subscribe(mobile);
            mobile.SimulateCheckList();

            
        }
    }
}
