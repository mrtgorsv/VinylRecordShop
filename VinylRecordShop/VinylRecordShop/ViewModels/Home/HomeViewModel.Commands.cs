using System.Windows.Input;
using VinylRecordShop.Logic;
using VinylRecordShop.Pages.Author;
using VinylRecordShop.Pages.Publisher;
using VinylRecordShop.ViewModels.Base;
using VinylRecordShop.ViewModels.VinylRecords;
using VinylRecordListPage = VinylRecordShop.Pages.VinylRecord.VinylRecordListPage;

namespace VinylRecordShop.ViewModels.Home
{
    public partial class HomeViewModel :ViewModelBase
    {
        public ICommand ShowVinylRecordListCommand
        {
            get { return new DelegateCommand(ShowVinylRecordList); }
        }

        public ICommand ShowAuthorListCommand
        {
            get { return new DelegateCommand(ShowAuthorList); }
        }

        public ICommand ShowPublisherListCommand
        {
            get { return new DelegateCommand(ShowPublisherList); }
        }

        private void ShowPublisherList()
        {
            Navigate(new PublisherListPage());
        }

        private void ShowAuthorList()
        {
            Navigate(new AuthorListPage());
        }

        private void ShowVinylRecordList()
        {
            var page = new VinylRecordListPage(new VinylRecordListViewModel());
            Navigate(page);
        }
    }
}