using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AR_SSE.Commands
{
    public class LoginCommand: ICommand
    {
        private Action DoWork;
        public LoginCommand(Action action)
        {
            //user passing action
            DoWork = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoWork();
        }

        public event EventHandler CanExecuteChanged;
    }
}
