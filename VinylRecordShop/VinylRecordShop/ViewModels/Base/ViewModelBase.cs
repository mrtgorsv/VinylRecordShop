using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using VinylRecordShop.Annotations;
using VinylRecordShop.Logic;

namespace VinylRecordShop.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void Navigate(Page page)
        {
            NavigationHelper.NavigationService.Navigate(page);
        }
    }
}
