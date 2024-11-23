using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Todoo.Core
{
    public class RelayCommand : ICommand
    {
        private Action mAction;

        public RelayCommand(Action akcja)
        {
            mAction = akcja;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }
    }
}
