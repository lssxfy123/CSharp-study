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

namespace binding_test5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 准备数据源
            List<Student> studentList = new List<Student>()
            {
                new Student() {Id = 0, Name = "Tim", Age = 29},
                new Student() {Id = 1, Name = "Tom", Age = 28},
                new Student() {Id = 2, Name = "Kyle", Age = 27},
                new Student() {Id = 3, Name = "Tony", Age = 26},
                new Student() {Id = 4, Name = "Vina", Age = 25},
                new Student() {Id = 5, Name = "Mike", Age = 24}
            };

            // 为ListBox设置Binding
            listBoxStudents.ItemsSource = studentList;

            // 为ID的TextBox设置Binding
            Binding binding = new Binding("SelectedItem.Id") { Source = listBoxStudents };
            textBoxId.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
