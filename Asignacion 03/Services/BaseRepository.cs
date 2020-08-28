using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornDemoApi.Services
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal UnicornDemoContext  context;
        internal DbSet<TEntity> dbSet;

    Public BaseRepository(UnicornDemoContext context)
        {
        this .context = context;
            this .dbSet = context.Set<TEntity>();

        }

        public void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Delete(entityToDelete);
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter! = null)
            {
                query = query.Where(filter);
            }

            if (includeProperties! = null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy! = null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public TEntity  GetById(object Id)
        {
            return dbSet.Find(id);

        }

        public empty insert(entity entity)
        {
            dbSet.Add(entity);
        }

        public void update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
}
}

