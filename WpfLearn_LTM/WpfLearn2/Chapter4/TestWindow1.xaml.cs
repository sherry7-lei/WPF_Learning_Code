using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace WpfLearn2.Chapter4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TestWindow1.Content属性引着StackPanel的实例
            StackPanel stackPanel = this.Content as StackPanel;
            // StackPanel实例的Children[0]引着TextBox的实例
            TextBox textBox = stackPanel.Children[0] as TextBox;
            if (string.IsNullOrEmpty(textBox.Text) )
            {
                textBox.Text = "Empty!";
            }
            else
            {
                textBox.Text = textBox.Name;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tb.Text))
            {
                tb.Text = "Empty!";
            }
            else
            {
                // 点击两次按钮，textbox出现tb：表明x:name 不仅可以声明引用变量，还可以为实例的Name赋值
                tb.Text = tb.Name;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // 通过FindResource找到Key为myString的对象，取出Value
            String str = this.FindResource("myString") as string;
            this.textBox.Text = str;
        }
    }
}
