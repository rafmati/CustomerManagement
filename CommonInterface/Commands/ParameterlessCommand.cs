using System;
using System.Windows.Input;

namespace CommonInterface.Commands
{
    internal class ParameterlessCommand : ICommand
    {
        private Action _action;

        public event EventHandler CanExecuteChanged;

        public ParameterlessCommand(Action action_)
        {
            if (action_ == null)
                throw new ArgumentNullException();
            this._action = action_;
        }

        public bool CanExecute(object parameter_)
        {
            var handler = this.CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            return parameter_ == null;
        }

        public void Execute(object parameter_)
        {
            if (parameter_ == null)
                this._action();
            else
                throw new ArgumentException("No argument required/expected");
        }
    }
}