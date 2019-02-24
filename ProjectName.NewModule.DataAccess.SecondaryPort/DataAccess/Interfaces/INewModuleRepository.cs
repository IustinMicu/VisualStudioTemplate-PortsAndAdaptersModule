using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;

namespace $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.DataAccess.Interfaces
{
    public interface I$ext_NewModuleName$Repository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(Guid id);

        TEntity GetSingleBy(Expression<Func<TEntity, bool>> filterCriteria);

        IEnumerable<TEntity> List();

        IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> filterCriteria);

        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}