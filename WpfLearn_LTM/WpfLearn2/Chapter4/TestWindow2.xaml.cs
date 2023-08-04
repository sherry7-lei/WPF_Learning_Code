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

namespace WpfLearn2.Chapter4
{

    /// <summary>
    /// TestWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow2 : Window
    {
        public static string MyTitle = "山高小月";
        public static string MyContent { get { return "水落石出"; } set { } }

        public TestWindow2()
        {
            InitializeComponent();
        }
    }
}
