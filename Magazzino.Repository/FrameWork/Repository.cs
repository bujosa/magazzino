using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Magazzino.Data.Infraestructure;
using Magazzino.Repository.FrameWork;


namespace Magazzino.Repository.FrameWork
{
    public class Repository<T> : Framework.IRepository<T>  where T : class
    {
        public DataResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public DataResult GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult GetAll(Expression<Func<T, bool>> specification, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public DataResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DataResult Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DataResult Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
