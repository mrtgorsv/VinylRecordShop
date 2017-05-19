using System.Windows.Input;
using VinylRecordShop.Logic;

namespace VinylRecordShop.ViewModels.Base
{
    public partial class EntityViewModel<T>
    {
        public ICommand CancelCommand
        {
            get { return new DelegateCommand(Cancel); }
        }

        public ICommand SaveCommand
        {
            get { return new DelegateCommand(Save); }
        }
    }
}
