using System;

namespace hMvvm.Commands
{
    public class Command
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public Command(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute)); _canExecute = canExecute;
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        } 
    }
}