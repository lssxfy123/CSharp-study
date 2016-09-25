using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace attached_event_test1
{
    class Student
    {
        // 声明并定义路由事件（附加事件）
        public static readonly RoutedEvent NameChangedEvent = EventManager
            .RegisterRoutedEvent("NameChanged", RoutingStrategy.Bubble, 
            typeof(RoutedEventHandler), typeof(Student));

        // 为界面元素添加路由事件侦听包装器
        public static void AddNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                // Student本身不是UIElement类
                // 通过别的UIElement对象侦听路由事件
                e.AddHandler(Student .NameChangedEvent, h);
            }
        }

        // 移除侦听
        public static void RemoveNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.RemoveHandler(Student.NameChangedEvent, h);
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
