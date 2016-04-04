using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EF
{
    interface IGenericRepository<T> where T : class
    {
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> SelectAll();
        T SelectByID(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
