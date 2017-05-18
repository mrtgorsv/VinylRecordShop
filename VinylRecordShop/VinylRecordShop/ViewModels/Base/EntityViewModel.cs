using VinylRecodShop.Model.Partial;
using VinylRecordShop.Services.Services;

namespace VinylRecordShop.ViewModels.Base
{
    public partial class EntityViewModel<T> : ViewModelBase where T: IEntity 
    {
        private int? _entityId;
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
        }

        public EntityViewModel(int entityId , IEntityService<T> service)
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
