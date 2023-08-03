using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace WpfLearn2.Chapter3
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
            Human h = (Human)FindResource("human");
            text.Text = h.Name + " " + h.Child.Name;
        }
    }

    // 利用TypeConverter将HumanToStringTypeConverter类作为特性附加到Human类上
    // 使得Human类可接受String类型的字符串赋值
    [TypeConverter(typeof(HumanToStringTypeConverter))]
    public class Human
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }
    // 重写了类型转换函数，相当于可以用String类型给自定义类型（Human）赋值
    public class HumanToStringTypeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string name = value.ToString();
            Human child = new Human();
            child.Name = name;
            return child;
        }
    }
}
