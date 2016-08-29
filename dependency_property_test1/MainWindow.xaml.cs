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

namespace dependency_property_test1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            simple = new Simple();

            // 由于Simple不是UIElement的派生类型，
            // 无法在XAML中添加绑定
            Binding binding = new Binding();
            binding.Source = simple;
            binding.Path = new PropertyPath("YearPublished");
            binding.Mode = BindingMode.TwoWay;
            textBlock.SetBinding(TextBlock.TextProperty, binding);
        }

        private Simple simple;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ++simple.YearPublished;
        }
    }
}
