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

namespace _007.User_Control
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Fill= Brushes.Red;
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Fill = Brushes.Green;

        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Fill = Brushes.Blue;

        }
    }
}
//Margin="왼 위 오른 아래"