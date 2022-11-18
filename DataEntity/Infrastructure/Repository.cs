using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly FashionWebDBContext _dbContext;
        private readonly IDbSet<T> _dbSet;
        public Repository()
        {
            _dbContext = new FashionWebDBContext();
            _dbSet = _dbContext.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public virtual T Delete(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return entity;
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
