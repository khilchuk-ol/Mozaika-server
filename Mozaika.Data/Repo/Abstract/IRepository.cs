using System;
using System.Collections.Generic;

namespace Mozaika.Data.Repo.Abstract
{
    public interface IRepository<TEntity, TIdentity>
    {
        void Create(TEntity item);
        void Update(TEntity item);
        void Remove(TEntity item);
        TEntity FindById(TIdentity id);
        IEnumerable<TEntity> Find(Func<TEntity, bool> filter);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetPage(int offset, int amount, Func<TEntity, bool> filter = null);
    }
}
