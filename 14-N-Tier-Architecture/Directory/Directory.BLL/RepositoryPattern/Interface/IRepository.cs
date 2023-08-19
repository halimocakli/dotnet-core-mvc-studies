using Directory.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Directory.BLL.RepositoryPattern.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetActives();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
    }
}
