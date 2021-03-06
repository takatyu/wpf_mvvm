using System;
using System.Windows.Input;

namespace wpf_memo.Commands
{
    class PushButtonCommand : ICommand
    {

        private readonly ViewModels.MainWindowViewModel _viewModel;

        public PushButtonCommand(ViewModels.MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
            // throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _viewModel.Value++;
            // throw new NotImplementedException();
        }
    }
}
