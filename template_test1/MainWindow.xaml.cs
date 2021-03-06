﻿using System;
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

namespace template_test1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialCarList();
        }

        // 初始化ListBox
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() {Automaker = "Lamborghini", Name = "benz",  Year="1990", TopSpeed = "340"},
                 new Car() {Automaker = "Lamborghini", Name = "dasatuo",  Year="2001", TopSpeed = "353"}
            };

            foreach (Car car in carList)
            {
                CarListItemView view = new CarListItemView();
                view.Car = car;
                listBoxCars.Items.Add(view);
            }
        }

        private void listBoxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarListItemView view = e.AddedItems[0] as CarListItemView;
            if (view != null)
            {
                detailView.Car = view.Car;
            }
        }
    }
}
