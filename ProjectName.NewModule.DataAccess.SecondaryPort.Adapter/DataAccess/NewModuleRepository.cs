using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.DataAccess.Interfaces;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;

namespace $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter.DataAccess
{
    public class NewModuleRepository<TEntity> : INewModuleRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly NewModuleDbContext dbContext;

        public NewModuleRepository(NewModuleDbContext newModuleDbContext)
        {
            this.dbContext = newModuleDbContext;
        }

        public TEntity GetById(Guid id)
        {
            return this.dbContext.Set<TEntity>().Find(id);
        }

        public TEntity GetSingleBy(Expression<Func<TEntity, bool>> filterCriteria)
        {
            return this.List(filterCriteria).FirstOrDefault();
        }

        public IEnumerable<TEntity> List()
        {
            return this.dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filterCriteria)
        {
            return this.dbContext.Set<TEntity>().Where(filterCriteria).ToList();
        }

        public TEntity Add(TEntity entity)
        {
            this.dbContext.Set<TEntity>().Add(entity);
            this.dbContext.SaveChanges();

            return entity;
        }

        public void Update(TEntity entity)
        {
            this.dbContext.Entry(entity).State = EntityState.Modified;
            this.dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            this.dbContext.Set<TEntity>().Remove(entity);
            this.dbContext.SaveChanges();
        }
    }
}
