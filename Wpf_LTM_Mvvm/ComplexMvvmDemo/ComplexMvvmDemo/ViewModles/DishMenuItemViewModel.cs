using ComplexMvvmDemo.Modles;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComplexMvvmDemo.ViewModles
{
    // BindableBase 等同于 NotificationObject
    internal class DishMenuItemViewModel : BindableBase
    {
        public Dish Dish { get; set; }

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }
    }
}
