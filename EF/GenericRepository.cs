using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private MyDbContext db = null;
        private DbSet<T> table = null;

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = db.Set<T>().Where(predicate);
            return query;
        }

        public GenericRepository()
        {
            this.db = new MyDbContext();
            table = db.Set<T>();
        }
        public GenericRepository(MyDbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
       
        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }
        public T SelectByID(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
