using System;
using System.Collections.Generic;
using System.IO;
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

namespace template_test1
{
    /// <summary>
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        public CarDetailView()
        {
            InitializeComponent();
        }

        private Car car;
        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                textBlockName.Text = car.Name;
                textBlockYear.Text = car.Year;
                textBlockTopSpeed.Text = car.TopSpeed;
                textBlockAutomaker.Text = car.Automaker;
                string uri = string.Format(@"/Resources/Image/{0}.jpg", car.Name);
                if (File.Exists(uri))
                {

                }
                imagePhoto.Source = new BitmapImage(new Uri(uri, UriKind.RelativeOrAbsolute));
            }
        }
    }
}
