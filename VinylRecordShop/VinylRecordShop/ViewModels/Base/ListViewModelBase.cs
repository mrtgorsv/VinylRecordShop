using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using VinylRecodShop.Model.Partial;
using VinylRecordShop.Services.Services;

namespace VinylRecordShop.ViewModels.Base
{
    public partial class ListViewModelBase<T> : ViewModelBase where T : class , IEntity 
    {
        private BindingList<T> _dataSource;
        private IEntityService<T> _entityService;
        private T _selectedItem;

        public virtual BindingList<T> EntityDataSource
        {
            get { return _dataSource ?? (_dataSource = new BindingList<T>(LoadDataSource())); }
            set
            {
                _dataSource = value;
                OnPropertyChanged();
            }
        }

        public IEntityService<T> EntityService
        {
            get { return _entityService; }
            set { _entityService = value; }
        }

        public T SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        public ListViewModelBase(IEntityService<T> service)
        {
            _entityService = service;
        }

        protected virtual List<T> LoadDataSource()
        {
            return _entityService.GetAll();
        }

        protected virtual Page GetDetailPage(int entityId = 0)
        {
            return new Page();
        }

        private void RefreshDataSource()
        {
            EntityDataSource = new BindingList<T>(LoadDataSource());
        }
    }
}