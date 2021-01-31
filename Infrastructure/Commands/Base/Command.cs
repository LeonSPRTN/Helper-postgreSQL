using System;
using System.Windows.Input;

namespace Helper_postgreSQL.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand 
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);


        public abstract void Execute(object parameter);

    }
}
