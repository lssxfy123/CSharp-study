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

namespace binding_test1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Student dataSource;

        public MainWindow()
        {
            InitializeComponent();

            // 准备数据源
            dataSource = new Student();

            // 准备绑定
            Binding binding = new Binding();
            binding.Source = dataSource;

            // 绑定到数据源的哪个属性
            binding.Path = new PropertyPath("Name");

            // 连接数据源和目标
            BindingOperations.SetBinding(textBoxName, TextBox.TextProperty, binding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataSource.Name += "Name";
        }
    }
}
