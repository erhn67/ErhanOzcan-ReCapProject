using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRespository<T> where T:class,Entity, new()
    {
        List<T> GetByAll(Expression<Func<T, bool>> filter = null);
        //T GetById(int id);//Expression<Func<T,bool>> filter);
        T GetById(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
