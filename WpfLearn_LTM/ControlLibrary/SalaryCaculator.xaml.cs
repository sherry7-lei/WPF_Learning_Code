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

namespace ControlLibrary
{
    /// <summary>
    /// SalaryCaculator.xaml 的交互逻辑
    /// </summary>
    public partial class SalaryCaculator : UserControl
    {
        public SalaryCaculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.text3.Text = (int.Parse(this.text1.Text) + int.Parse(this.text2.Text)).ToString();
        }
    }

}
