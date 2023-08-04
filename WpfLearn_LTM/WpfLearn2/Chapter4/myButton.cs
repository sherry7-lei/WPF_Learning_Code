using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfLearn2.Chapter4
{
    internal class myButton : Button
    {
        // 声明一个属性UserWindowType，存储着Type类型的变量
        public Type UserWindowType { get; set; }

        protected override void OnClick()
        {
            // 激发Click事件
            base.OnClick();
            // 通过反射创建对象(前端通过传入的myWindow创建对象win)
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if (win != null )
            {
                win.ShowDialog();
            }
        }
    }
}
