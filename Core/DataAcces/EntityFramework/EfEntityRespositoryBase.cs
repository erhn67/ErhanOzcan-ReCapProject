using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcces.EntityFramework
{
    public class EfEntityRespositoryBase<TEntity, TContext> : IEntityRespository<TEntity>
         where TEntity : class, Entity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context= new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;//Eklenecek nesne
                context.SaveChanges();// işlemleri gerçekleştirir.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                // git veri kaynağından Product entity den bir tane nesneyi eşleştir
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;//silinecek nesne
                context.SaveChanges();// işlemleri gerçekleştirir.
            }
        }

        public List<TEntity> GetByAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // eğer filter null ise bütün tabloyu listeye çevir bana ver(arka planda selecet * from Products döndürür)
                return filter == null ? context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();// fitre null değilse filtreleyip ver
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                //context.Set<Product>() ==> Product tablosuna bağlan
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                // git veri kaynağından Product entity den bir tane nesneyi eşleştir
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;//güncellenecek nesne
                context.SaveChanges();// işlemleri gerçekleştirir.

                
            }
        }
    }
}
