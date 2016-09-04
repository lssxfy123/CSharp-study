// Copyright 2016.刘珅珅
// author：刘珅珅
// 路由事件
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace routed_event_test1
{
    // 路由事件参数
    public class ReportedLocationEventArgs:RoutedEventArgs
    {
        public ReportedLocationEventArgs(RoutedEvent routedEvent, object source)
            : base(routedEvent, source)
        { }

        public string Location { get; set; }
    }

    public class ReportLocationButton:Button
    {
        // 声明并定于路由事件
        // 向上冒泡的路由事件
        public static readonly RoutedEvent ReportLocationEvent = EventManager
            .RegisterRoutedEvent("ReportTime", RoutingStrategy.Bubble,
            typeof(EventHandler<ReportedLocationEventArgs>), typeof(ReportLocationButton));

        // CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            add { AddHandler(ReportLocationEvent, value); }
            remove { RemoveHandler(ReportLocationEvent, value); }
        }

        // 激发路由事件
        protected override void OnClick()
        {
            base.OnClick();

            ReportedLocationEventArgs args = new ReportedLocationEventArgs(ReportLocationEvent, this);
            args.Location = this.Name;
            this.RaiseEvent(args);  // 激发路由事件
        }
    }
}
