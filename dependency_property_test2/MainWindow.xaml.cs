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

namespace dependency_property_test2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student student = new Student();

            // 设置绑定的数据源和Path
            // 数据源为textBox1，Path为Text属性
            student.SetBinding(Student.NameProperty, new Binding("Text") { Source = textBox1});

            // 数据源为student，Path为Name属性
            textBox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = student});
        }
    }
}
