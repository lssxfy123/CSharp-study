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

namespace binding_test8
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetBinding();
        }

        private void SetBinding()
        {
            // 创建并配置ObjectDataProvider对象
            ObjectDataProvider odp = new ObjectDataProvider();

            // 被包装对象
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            // 以ObjectDataProvider对象为Source创建Binding
            Binding bindingToArg1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                // 把从UI元素收集到的数据写入其直接Source（即ObjectDataProvider），
                // 而不是被ObjectDataProvider包装着的Calculator对象
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            // 数据源本身代表数据，使用"."作为Path
            Binding bindingToResult = new Binding(".") { Source = odp };

            // 将Binding关联到UI元素
            textBoxArg1.SetBinding(TextBox.TextProperty, bindingToArg1);
            textBoxArg2.SetBinding(TextBox.TextProperty, bindingToArg2);
            textBoxResult.SetBinding(TextBox.TextProperty, bindingToResult);
        }
    }
}
