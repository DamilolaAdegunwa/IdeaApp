using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdeaApp.Data.Repository
{
    public interface IBaseRepository<TEntity,TKey>
    {
        TEntity Get(TKey Id);
        IQueryable<TEntity> GetAll();
        TEntity Update(TEntity entity);
        TEntity Create(TEntity entity);
        bool Delete(TKey Id);
    }
}
