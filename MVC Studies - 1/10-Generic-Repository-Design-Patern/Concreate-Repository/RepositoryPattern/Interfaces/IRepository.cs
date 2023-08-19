﻿using Concreate_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Concreate_Repository.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetActiveData();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SpecialDelete(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> exp);
        int Count();
        bool Any(Expression<Func<T, bool>> exp);
        List<T> SelectActivesByLimit(int limit);
    }
}
