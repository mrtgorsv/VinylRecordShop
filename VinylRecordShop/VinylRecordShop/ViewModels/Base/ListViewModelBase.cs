using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using VinylRecodShop.Model.Partial;
using VinylRecordShop.Services.Services;

namespace VinylRecordShop.ViewModels.Base
{
    public partial class ListViewModelBase<T> : ViewModelBase where T : class , IEntity 
    {
        private BindingList<EntityViewModel<T>> _dataSource;
        private IEntityService<T> _entityService;
        private EntityViewModel<T> _selectedItem;

        public virtual BindingList<EntityViewModel<T>> EntityDataSource
        {
            get { return _dataSource ?? (_dataSource = new BindingList<EntityViewModel<T>>(LoadDataSource())); }
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

        public EntityViewModel<T> SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ItemSelected));
            }
        }
        public bool ItemSelected
        {
            get { return SelectedItem != null; }
        }

        public ListViewModelBase(IEntityService<T> service)
        {
            _entityService = service;
        }

        protected virtual List<EntityViewModel<T>> LoadDataSource()
        {
            return _entityService.GetAll().Select(Map).ToList();
        }

        protected virtual EntityViewModel<T> Map(T entity)
        {
            throw new System.NotImplementedException();
        }

        protected virtual Page GetDetailPage(int entityId = 0)
        {
            throw new System.NotImplementedException();
        }

        private void RefreshDataSource()
        {
            EntityDataSource = new BindingList<EntityViewModel<T>>(LoadDataSource());
        }
    }
}