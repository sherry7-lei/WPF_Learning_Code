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
using System.Windows.Shapes;

namespace WpfLearn2.Chapter5
{
    /// <summary>
    /// TestWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow1 : Window
    {
        public TestWindow1()
        {
            InitializeComponent();
        }

        private void buttonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DependencyObject level1 = VisualTreeHelper.GetParent(btn);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);
            MessageBox.Show(level3.GetType().ToString());
        }
    }
}
