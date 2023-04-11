using Restoran3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Restoran3.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object?> _executeShowCommand;
        private Func<object?, bool> _canExecuteShowCommand;

        private Button Btn;

        public RelayCommand(Action<object?> executeShowCommand, Func<object?, bool> canExecuteShowCommand, Button btn)
        {
            _executeShowCommand = executeShowCommand;
            _canExecuteShowCommand = canExecuteShowCommand;
            Btn = btn;
        }

        public event EventHandler? CanExecuteChanged;

        public void Execute(object? parameter)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        public bool CanExecute(object? parameter) => Btn.Background == new SolidColorBrush(Colors.Green);


    }
}
