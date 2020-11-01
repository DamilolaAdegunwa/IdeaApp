using IdeaApp.Data.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Text;
using IdeaApp.Core.Entity;
using System.Linq;

namespace IdeaApp.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity,long>
        where TEntity : FullAuditedEntity
    {
        public readonly IdeaAppDbContext db;
        public BaseRepository()
        {
            db = new IdeaAppDbContext();
        }

        public TEntity Create(TEntity entity)
        {
            return db.Add(entity).Entity;
        }

        public bool Delete(long Id)
        {
            try
            {
                var entity = Get(Id);
                db.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public TEntity Get(long Id)
        {
            return db.Query<TEntity>().Where(x => x.Id == Id).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
