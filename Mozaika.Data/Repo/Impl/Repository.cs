using Microsoft.EntityFrameworkCore;
using Mozaika.Data.Repo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mozaika.Data.Repo.Impl
{
    public class Repository<TEntity, TIdentity> : IRepository<TEntity, TIdentity> where TEntity : class
    {
        protected DbContext _context;
        
        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Create(TEntity item)
        {
            _context.Set<TEntity>().Add(item);
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> filter)
        {
            return _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity FindById(TIdentity id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetPage(int offset, int amount, Func<TEntity, bool> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().Skip(offset).Take(amount) : _context.Set<TEntity>().Skip(offset).Where(filter).Take(amount);
        }

        public void Remove(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
        }

        public void Update(TEntity item)
        {
            _context.Set<TEntity>().Attach(item);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
