using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using SimpleMvvmDemo.Commands;

namespace SimpleMvvmDemo.ViewModels
{
    internal class MainWindowViewModel : NotificationObject
    {
		// Views 和 ViewModels 交互有三个数据和两个命令
		private double input1;

		public double Input1
		{
			get { return input1; }
			set
			{
				input1 = value;
				this.RaisePropertyChanged("Input1");
			}
		}

		private double input2;

		public double Input2
		{
			get { return input2; }
			set
			{
				input2 = value;
				this.RaisePropertyChanged("Input2");
			}
		}

		// 成员变量
		private double result;
		// 属性
		public double Result
		{
			get { return result; }
			set
			{
				result = value;
				this.RaisePropertyChanged("Result");
			}
		}
        // 声明DelegateCommand对象AddCommand
        public DelegateCommand AddCommand { get; set; }
        // 声明DelegateCommand对象SaveCommand
        public DelegateCommand SaveCommand { get; set; }

        private void Add(object parameter)
		{
			this.Result = this.Input1 + this.Input2;
		}

		private void Save(object parameter) 
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.ShowDialog();
		}

        public MainWindowViewModel()
        {
            // 实例化DelegateCommand对象
            this.AddCommand = new DelegateCommand();
			// 
			this.AddCommand.ExecuteAction = new Action<object>(this.Add);

			this.SaveCommand = new DelegateCommand();
			this.SaveCommand.ExecuteAction = new Action<object>(this.Save);
        }
    }
}
