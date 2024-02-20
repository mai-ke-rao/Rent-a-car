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

namespace Rent_a_car
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMinimize(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }
        private void BtnLogin(object sender, RoutedEventArgs e)
        { 
            Navigation newWindow = new Navigation();
            newWindow.ShowDialog();
            Close();

        }
    }
}
