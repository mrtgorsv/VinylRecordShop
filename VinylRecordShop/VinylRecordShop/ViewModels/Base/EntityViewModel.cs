using System.Windows.Controls;
using VinylRecodShop.Model.Partial;
using VinylRecordShop.Logic;
using VinylRecordShop.Services.Services;

namespace VinylRecordShop.ViewModels.Base
{
    public abstract partial class EntityViewModel<T> : ViewModelBase where T: IEntity 
    {
        private int _entityId;
        private readonly IEntityService<T> _entityService;
        private T _entity;

        public T Entity
        {
            get { return _entity; }
        }

        public EntityViewModel()
        {
        }

        public EntityViewModel(T entity)
        {
            _entity = entity;
            _entityId = entity.Id;
        }

        public EntityViewModel(int entityId , IEntityService<T> service)
        {
            _entityId = entityId;
            _entityService = service;
            _entity = _entityService.Get(_entityId);
        }

        protected virtual void InitializeObject()
        {
            _entity = _entityService.Get(_entityId);
        }

        protected virtual void Save()
        {
            _entityService.AddOrUpdate(_entity);

            Navigate(GetListPage());
        }

        protected abstract Page GetListPage();

        protected virtual void Cancel()
        {
            NavigationHelper.NavigationService.GoBack();
        }
    }
}
