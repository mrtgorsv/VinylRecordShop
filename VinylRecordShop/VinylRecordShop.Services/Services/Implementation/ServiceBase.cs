using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecodShop.Model.Partial;

namespace VinylRecordShop.Services.Services.Implementation
{
    public class ServiceBase<T> : IEntityService<T> where T : class , IEntity
    {
        private VinylRecordEntities _context;
        public ServiceBase()
        {
            _context = new VinylRecordEntities();
        }
        public T Get(int id)
        {
            if (id == 0)
            {
                return Create();
            }
            return _context.Set<T>().FirstOrDefault(entity => entity.Id.Equals(id));
        }

        public bool Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

        public T Create()
        {
            return _context.Set<T>().Create();
        }

        public void AddOrUpdate(T entity)
        {
            if (entity.Id > 0)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                _context.Set<T>().Add(entity);
            }
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            var query = _context.Set<T>();
            return query.ToList();
        }
    }
}
