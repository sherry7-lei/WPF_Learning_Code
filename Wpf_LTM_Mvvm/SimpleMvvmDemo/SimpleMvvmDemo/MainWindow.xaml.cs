using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleMvvmDemo.ViewModels;

namespace SimpleMvvmDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // MVVM模式下应用程序分为UI层和数据层
            // UI层由MainWindow.xaml 和 MainWindow.xaml.cs组成
            // 数据层由ViewModles 和 Models组成
            // 程序默认的数据层是null 需要在构造函数中进行实例化
            this.DataContext = new MainWindowViewModel();
        }
    }
}
