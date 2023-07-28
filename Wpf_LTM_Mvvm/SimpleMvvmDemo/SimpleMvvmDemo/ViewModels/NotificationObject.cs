using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMvvmDemo.ViewModels
{
    internal class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // 当propertyName属性的值发生变化时PropertyChanged事件被激发，
        // banding接收到事件，并收到是名为propertyName的属性的值发生变化，
        // 于是banding目标端的UI值也会随之发生变化
        public void RaisePropertyChanged(string propertyName)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
