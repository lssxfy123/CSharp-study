using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace dependency_property_test1
{
    class Simple:DependencyObject
    {
        public int YearPublished
        {
            get { return (int)GetValue(YearPublishedProperty); }
            set { SetValue(YearPublishedProperty, value); }
        }

        public static readonly DependencyProperty YearPublishedProperty =
            DependencyProperty.Register("YearPublished", typeof(int), typeof(Simple), new PropertyMetadata(2013));
    }
}
