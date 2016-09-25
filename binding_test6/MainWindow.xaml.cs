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
using System.Xml;

namespace binding_test6
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
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\study\CSharp-study\binding_test6\RawData.xml");

            XmlDataProvider xdp = new XmlDataProvider();
            xdp.Document = doc;

            // 使用XPath选择需要暴露的数据
            // 现在是需要暴露一组Student
            xdp.XPath = @"/StudentList/Student";

            listViewStudents.DataContext = xdp;

            // 绑定没有指定源，使用DataContext作为源
            listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
