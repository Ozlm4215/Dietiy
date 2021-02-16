using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dietiy.Data.Infrastructure
{
   public interface IRepository<T> where T : class, new()
    {
        T Get(int id);
         
        T Get(Expression<Func<T, bool>> filter);

        IEnumerable<T> GetList();

        IEnumerable<T> GetList(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);

        void Remove(T entity);


    }
}
