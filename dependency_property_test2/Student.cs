using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace dependency_property_test2
{
    class Student:DependencyObject
    {
        // CLR属性包装器
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        
        // 依赖属性
        // Register函数的3个参数
        // 第1个参数为string类型，指明以哪个CLR属性作为依赖属性的包装器
        // 第2个参数用来指明依赖属性存储什么类型的值
        // 第3个参数指明依赖属性的宿主类型或者说依赖属性注册关联到哪个类型
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(Student));

        // SetBinding包装
        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}
