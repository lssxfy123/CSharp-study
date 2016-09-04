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

namespace attached_property_test1
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

        private void School_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human();

            // 在School附加了Grade属性
            School.SetGrade(human, 6);
            int grade = School.GetGrade(human);
            MessageBox.Show(grade.ToString());
        }

        private void Company_Click(object sender, RoutedEventArgs e)
        {
            // 在Company中附加了Project属性
            Human human = new Human();
            Company.SetProject(human, 5);
            int project = Company.GetProject(human);
            MessageBox.Show(project.ToString());
        }
    }
}
