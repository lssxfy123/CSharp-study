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

namespace resources_test2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 第一个button按钮通过静态方式获取资源res1
            // 第二个button按钮通过动态方式获取资源res2
            // 在程序里改变res1和res2时，可以发现，
            // 第一个button的内容不变，而第二个button
            // 的内容发生了改变
            Resources["res1"] = new TextBlock() { Text = "天涯共此时" };
            Resources["res2"] = new TextBlock() { Text = "天涯共此时" };
        }
    }
}
