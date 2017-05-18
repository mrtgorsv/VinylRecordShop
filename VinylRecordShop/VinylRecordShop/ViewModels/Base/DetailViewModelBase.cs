using VinylRecodShop.Model.Partial;
using VinylRecordShop.Services.Services;

namespace VinylRecordShop.ViewModels.Base
{
    public partial class DetailViewModelBase<T> : ViewModelBase where T: IEntity 
    {
        private int? _entityId;
        private readonly IEntityService<T> _entityService;
        private T _entity;

        protected T Entity
        {
            get { return _entity; }
        }

        public DetailViewModelBase()
        {
        }

        public DetailViewModelBase(T entity)
        {
            _entity = entity;
        }

        public DetailViewModelBase(int entityId , IEntityService<T> service)
        {
            _entityId = entityId;
            _entityService = service;
        }

        protected virtual void InitializeObject()
        {
            if (_entityId.HasValue)
            {
                _entity = _entityService.Get(_entityId.Value);
            }
        }

        protected virtual void Save()
        {
            _entityService.AddOrUpdate(_entity);
        }
    }
}
