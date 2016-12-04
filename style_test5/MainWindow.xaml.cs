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

namespace style_test5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitList();
        }

        void InitList()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student {ID = "1", Name = "Tim", Age = "28"},
                new Student {ID = "2", Name = "Tom", Age = "27"}
            };

            listBoxStudent.ItemsSource = studentList;
        }
    }
}
