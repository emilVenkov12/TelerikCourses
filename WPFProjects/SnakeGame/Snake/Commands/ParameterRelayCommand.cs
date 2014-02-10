using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Snake.Commands
{
    public delegate void ExecuteParameterDelegate(object parameter);
    public delegate bool CanExecuteParameterDelegate(object parameter);

    class ParameterRelayCommand : ICommand
    {
        #region Fields

        private ExecuteParameterDelegate _execute;
        private CanExecuteParameterDelegate _canExecute;

        #endregion

        #region Consturctors

        public ParameterRelayCommand(ExecuteParameterDelegate execute)
            : this(execute, null)
        { }

        public ParameterRelayCommand(ExecuteParameterDelegate execute, CanExecuteParameterDelegate canExecute)
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
            return this._canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        #endregion
    }
}
