﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;




namespace MovieRoulette
{
    class RelayCommand : ICommand
    {
        private readonly Action _execute = null;
        private readonly Func<bool> _canExecute = null;
        // private DispatcherTimer canExecuteChangedEventTimer = null;

        public RelayCommand(Action methodToExecute, Func<bool> methodToDetectCanExecute)
        {
            _execute = methodToExecute;
            _canExecute = methodToDetectCanExecute;
        }

        public void Execute(object paremeter)
        {
            this._execute();
        }

        public bool CanExecute(object parameter)
        {
            if (this._canExecute == null)
            {
                return true;
            }
            else
            {
                return this._canExecute();
            }
        }

        public event EventHandler CanExecuteChanged;


    }
}
