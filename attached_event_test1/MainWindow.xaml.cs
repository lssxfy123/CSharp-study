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

namespace attached_event_test1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 为外层Grid添加路由（附加）事件侦听器
            Student.AddNameChangedHandler(
                this.gridMain, new RoutedEventHandler(StudentNameChangedHandler));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student() { Id = 101, Name = "Tim" };
            student.Name = "Tom";

            // 准备事件消息并发送路由事件
            RoutedEventArgs arg = new RoutedEventArgs(Student.NameChangedEvent, student);

            // Student本身不是UIElement类派生类
            // 通过Button来激发路由事件
            button.RaiseEvent(arg);
        }

        // Grid捕捉到NameChangedEvent后的处理器
        private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).Id.ToString());
        }
    }
}
