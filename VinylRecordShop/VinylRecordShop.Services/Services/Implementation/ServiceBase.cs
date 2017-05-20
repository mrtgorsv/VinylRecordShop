using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecodShop.Model.Partial;

namespace VinylRecordShop.Services.Services.Implementation
{
    public class ServiceBase<T> : IEntityService<T> where T : class , IEntity
    {
        protected VinylRecordEntities EntityContext;
        public ServiceBase()
        {
            EntityContext = new VinylRecordEntities();
        }
        public T Get(int id)
        {
            if (id == 0)
            {
                return Create();
            }
            return EntityContext.Set<T>().FirstOrDefault(entity => entity.Id.Equals(id));
        }

        public bool Delete(T entity)
        {
            EntityContext.Entry(entity).State = EntityState.Deleted;
            EntityContext.SaveChanges();
            return true;
        }

        public T Create()
        {
            return EntityContext.Set<T>().Create();
        }

        public void AddOrUpdate(T entity)
        {
            if (entity.Id == 0)
            {
                EntityContext.Set<T>().Add(entity);
            }

            DbEntityEntry<T> entityEntry = EntityContext.Entry(entity);
            entityEntry.State = entity.Id == 0 ? EntityState.Added : EntityState.Modified;

            EntityContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            var query = EntityContext.Set<T>();
            return query.ToList();
        }

        public virtual bool CanDelete(int id)
        {
            return true;
        }

        public bool SaveChanges()
        {
            EntityContext.SaveChanges();
            return true;
        }
    }
}
