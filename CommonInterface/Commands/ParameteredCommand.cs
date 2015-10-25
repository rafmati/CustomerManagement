using System;
using System.Windows.Input;

namespace CommonInterface.Commands
{
    internal class ParameteredCommand<TArgs> : ICommand
    {
        private Action<TArgs> _action;

        public event EventHandler CanExecuteChanged;

        public ParameteredCommand(Action<TArgs> action_)
        {
            if (action_ == null)
                throw new ArgumentNullException();
            this._action = action_;
        }

        public bool CanExecute(object parameter)
        {
            var handler = this.CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            return parameter is TArgs;
        }

        public void Execute(object parameter)
        {
            this._action((TArgs)parameter);
        }
    }
}