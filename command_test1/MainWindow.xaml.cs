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

namespace command_test1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializedCommand();
        }

        // 声明并定义命令
        private RoutedCommand clearCommand = new RoutedCommand("Clear", typeof(MainWindow));

        private void InitializedCommand()
        {
            // 把命令赋值给命令源（发送者）
            button.Command = clearCommand;

            // 指定命令目标
            button.CommandTarget = textBox;

            // 创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = clearCommand;
            cb.CanExecute += cb_CanExecute;
            cb.Executed += cb_Executed;

            // 把命令关联安置在外围控件上
            stackPanel.CommandBindings.Add(cb);
        }

        // 当探测命令是否可以执行时，此方法被调用
        void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }

            // 避免继续向上传而降低程序性能
            e.Handled = true;
        }

        // 当命令送达目标后，此方法被调用
        void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Clear();

            // 避免向上传递而降低程序性能
            e.Handled = true;
        }
    }
}
