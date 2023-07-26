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

namespace WpfLearn2
{
    /// <summary>
    /// TestWindow3.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow3 : Window
    {
        public TestWindow3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 由于TestWindow1/2/3/4都在WpfLearn2这个命名空间下，因此在同一个项目中各个文件都可以相互调用
            TestWindow1 Tw1 = new TestWindow1();
            Tw1.text.Text = "Hello";
            Tw1.ShowDialog();
        }
    }
}
