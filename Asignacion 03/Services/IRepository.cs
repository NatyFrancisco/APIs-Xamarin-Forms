using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornDemoApi.Services
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entityToInsert);
        void Update(TEntity entityToUdate);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQuerybable<TEntity>, IOrderedQueryable<TEntity>> ordeBy = null,
            string includeProperties = "");
        TEntity GetById(object Id);
        void Delete(TEntity entityToDelete);

        void Delete(objet Id);
    }
}
