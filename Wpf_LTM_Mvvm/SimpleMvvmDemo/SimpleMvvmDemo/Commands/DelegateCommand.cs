using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMvvmDemo.Commands
{
    internal class DelegateCommand : ICommand
    {
        // 当命令执行状态发生改变时，通知命令的调用者状态发生变化
        public event EventHandler CanExecuteChanged;

        // 用于帮助命令呼叫者判断命令是否可执行
        public bool CanExecute(object parameter)
        {
            if(this.CanExecuteFunc == null)
            {
                return true;
            }

            return this.CanExecuteFunc(parameter);
        }

        // 当命令执行时的业务逻辑
        public void Execute(object parameter)
        {
            if(this.ExecuteAction == null)
            {
                return;
            }
            this.ExecuteAction(parameter);
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<object,bool> CanExecuteFunc { get; set; }
    }
}
