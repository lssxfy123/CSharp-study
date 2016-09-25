using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace binding_test9
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            // 准备基础Binding
            Binding b1 = new Binding("Text") { Source = textBox1 };
            Binding b2 = new Binding("Text") { Source = textBox2 };
            Binding b3 = new Binding("Text") { Source = textBox3 };
            Binding b4 = new Binding("Text") { Source = textBox4 }; 

            // 准备MultiBinding
            MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };

            // MultiBinding对Add子Binding的顺序是敏感的
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);
            mb.Bindings.Add(b3);
            mb.Bindings.Add(b4);

            // 数据转换
            mb.Converter = new LogonMultiBindingConvert();

            // 将Button与MultiBinding对象关联
            button.SetBinding(Button.IsEnabledProperty, mb);
        }
    }
}
