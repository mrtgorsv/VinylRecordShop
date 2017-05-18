using System.Windows.Input;

namespace VinylRecordShop.ViewModels.Base
{
    public partial class DetailViewModelBase<T>
    {
        private ICommand _saveCommand;
        private ICommand _cancelCommand;

        public ICommand SaveCommand
        {
            get { return _saveCommand; }
            set { _saveCommand = value; }
        }

        public ICommand CancelCommand
        {
            get { return _cancelCommand; }
            set { _cancelCommand = value; }
        }
    }
}
