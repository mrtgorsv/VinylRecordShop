using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using VinylRecodShop.Model.Database.DatabaseContext;
using VinylRecodShop.Model.Partial;

namespace VinylRecordShop.Services.Services.Implementation
{
    public class ServiceBase<T> : IEntityService<T> where T : class , IEntity
    {
        public T Get(int id)
        {
            using (VinylRecordEntities context = new VinylRecordEntities())
            {
                return context.Set<T>().FirstOrDefault(entity => entity.Id.Equals(id));
            }
        }

        public bool Delete(T entity)
        {
            using (VinylRecordEntities context = new VinylRecordEntities())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
        }

        public T Create()
        {
            using (VinylRecordEntities context = new VinylRecordEntities())
            {
                return context.Set<T>().Create();
            }
        }

        public void AddOrUpdate(T entity)
        {
            using (VinylRecordEntities context = new VinylRecordEntities())
            {
                if (entity.Id > 0)
                {
                    context.Entry(entity).State = EntityState.Modified;
                }
                else
                {
                    context.Set<T>().Add(entity);
                }
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (VinylRecordEntities context = new VinylRecordEntities())
            {
                var query = context.Set<T>();
                return query.ToList();
            }
        }
    }
}
