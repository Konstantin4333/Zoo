﻿using System;
using System.Windows.Input;

namespace ZooProject.Command
{
    public class Command : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public Command(Predicate<object> canExecute, Action<object> execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
