using Directory.BLL.RepositoryPattern.Interface;
using Directory.DAL.Context;
using Directory.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Directory.BLL.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        MyDbContext _db;
        protected DbSet<T> table;
        public Repository(MyDbContext db)
        {
            _db = db;
            table = db.Set<T>();
        }
        private void Save()
        {
            _db.SaveChanges();
        }

        public void Add(T entity)
        {
            table.Add(entity);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return table.Any(exp);
        }

        public void Delete(int id)
        {
            T item = GetById(id);
            item.Status = MODEL.Enums.DataStatus.Deleted;
            item.UpdatedDate = DateTime.Now;
            table.Update(item);
            Save();
        }

        public List<T> GetActives()
        {
            return table.Where(x => x.Status != MODEL.Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Update(T entity)
        {
            entity.Status = MODEL.Enums.DataStatus.Updated;
            entity.UpdatedDate = DateTime.Now;
            table.Update(entity);
            Save();
        }
    }
}
