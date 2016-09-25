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

namespace routed_event_test1
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

        // 路由事件的事件处理函数
        private void ReportTimeHandler(object sender, ReportedLocationEventArgs e)
        {
            e.Location = (sender as FrameworkElement).Name;
            string l = e.Location;
            string c = "我到达了: " + l;
            this.listbox.Items.Add(c);
        }
    }
}
