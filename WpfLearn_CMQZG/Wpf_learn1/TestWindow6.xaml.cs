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
using System.Windows.Shapes;

namespace Wpf_learn1
{
    /// <summary>
    /// TestWindow6.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow6 : Window
    {
        public TestWindow6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyText.Text = "sherry";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MyText.Text = "on";
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MyText.Text = "off";
        }
    }
}
