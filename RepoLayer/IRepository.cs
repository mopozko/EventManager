﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepoLayer
{
    public interface IRepository<TEntity>
         where TEntity : Entity
    {
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entitys);
        void Update(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        void Delete(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
