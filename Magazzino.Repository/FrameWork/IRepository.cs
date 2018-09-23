using System;
using System.Linq.Expressions;
using Magazzino.Data.Infraestructure;

namespace Magazzino.Repository.Framework
{
    public interface IRepository<T>
    {
        DataResult GetAll();
        DataResult GetAll(Expression<Func<T, bool>> specification,
                          params Expression<Func<T, object>>[] includeProperties);
        DataResult GetById(int id);
        DataResult Insert(T entity);
        DataResult Update(T entity);
        DataResult Delete(T entity);

        Boolean SaveChanges();
    }
}