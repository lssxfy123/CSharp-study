// Copyright 2016.刘珅珅
// author：刘珅珅
// 附加属性
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace attached_property_test1
{
    class Human:DependencyObject
    {
    }

    // 学校
    class School:DependencyObject
    {
        // 附加属性的包装器
        public static int GetGrade(DependencyObject obj)
        {
            return (int)obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty, value);
        }

        // 附加属性
        public static readonly DependencyProperty GradeProperty =
            DependencyProperty.RegisterAttached("Grade", typeof(int), 
            typeof(School), new UIPropertyMetadata(0));
    }

    // 公司
    class Company : DependencyObject
    {
        // 附加属性的包装器
        public static int GetProject(DependencyObject obj)
        {
            return (int)obj.GetValue(ProjectProperty);
        }

        public static void SetProject(DependencyObject obj, int value)
        {
            obj.SetValue(ProjectProperty, value);
        }

        // 附加属性
        public static readonly DependencyProperty ProjectProperty =
            DependencyProperty.RegisterAttached("Project", typeof(int),
            typeof(Company), new UIPropertyMetadata(0));
    }

}
