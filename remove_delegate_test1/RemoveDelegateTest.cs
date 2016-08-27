// Copyright 2016.刘珅珅
// author：刘珅珅
// 移除事件的所有委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace remove_delegate_test1
{
    class MyClass
    {
        public event EventHandler<int> SomeEvent;
        public event EventHandler AnotherEvent;

        public void SimulateEvent()
        {
            if (SomeEvent != null)
                SomeEvent(this, 5);

            if (AnotherEvent != null)
            {
                EventArgs e = new EventArgs();
                AnotherEvent(this, e);
            }
        }

        public bool IsSomeEventNull()
        {
            if (SomeEvent == null)
                return true;
            return false;
        }

        public bool IsAnotherEventNull()
        {
            if (AnotherEvent == null)
                return true;
            return false;
        }
    }

    class RemoveDelegateTest
    {
        static void Handler1(object sender, int n)
        {
            Console.WriteLine("SomeEvent " + n);
        }

        static void Handler2(object sender, EventArgs e)
        {
            Console.WriteLine("AnotherEvent");
        }

        // 移除事件的委托
        static void RemoveEvent<T>(T c, string name)
        {
            Delegate[] invokeList = GetObjectEventList(c, name);
            if (invokeList != null)
            {
                foreach (Delegate del in invokeList)
                {
                    Console.WriteLine("delete Delegate name " + name);
                    typeof(T).GetEvent(name).RemoveEventHandler(c, del);
                }
                    
            }
        }

        // 获取事件委托列
        public static Delegate[] GetObjectEventList(object obj, string event_name)
        {
            FieldInfo field_info = obj.GetType().GetField(event_name, 
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            if (field_info == null)
                return null;

            object field_value = field_info.GetValue(obj);
            if (field_value != null && field_value is Delegate)
            {
                Delegate delegate_obj = (Delegate)field_value;
                return delegate_obj.GetInvocationList();
            }

            return null;
        }

        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.SomeEvent += Handler1;
            obj.AnotherEvent += Handler2;
            obj.SomeEvent += Handler1;
            obj.AnotherEvent += Handler2;

            obj.SimulateEvent();

            Console.WriteLine();

            // 删除名称为SomeEvent事件上的所有委托
            RemoveEvent<MyClass>(obj, "SomeEvent");

            if (obj.IsSomeEventNull())
            {
                Console.WriteLine("SomeEvent is null");
            }

            Console.WriteLine();

            // 删除名称为AnotherEvent事件上的所有委托
            RemoveEvent<MyClass>(obj, "AnotherEvent");

            if (obj.IsAnotherEventNull())
            {
                Console.WriteLine("AnoterEvent is null");
            }
        }
    }
}
