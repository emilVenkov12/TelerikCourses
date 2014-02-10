using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Snake.Commands
{
    public delegate void ExecuteDelegate();
    public delegate bool CanExecuteDelegate();

    class RelayCommand : ICommand
    {
        #region Fields

        private ExecuteDelegate _execute;
        private CanExecuteDelegate _canExecute;

        #endregion

        #region Consturctors

        public RelayCommand(ExecuteDelegate execute)
            : this(execute, null)
        { }

        public RelayCommand(ExecuteDelegate execute, CanExecuteDelegate canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        #endregion

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            if (this._canExecute == null)
            {
                return true;
            }
            return this._canExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this._execute();
        }

        #endregion
    }
}
