using System;
using System.Windows.Input;

namespace ColoredDataGridCell.ViewModels.Common
{
    class RelayCommand : ICommand
    {
        private readonly Action action;

        public RelayCommand(Action act) => action = act;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => action != null;

        public void Execute(object parameter) => action?.Invoke();
    }
}
