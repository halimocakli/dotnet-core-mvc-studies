using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Fluent_Validation.Enums;
using Fluent_Validation.RepositoryPattern.Interfaces;
using Fluent_Validation.Models;
using Fluent_Validation.Context;

namespace Fluent_Validation.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private MyDbContext _db;
        protected DbSet<T> table;
        public Repository(MyDbContext db)
        {
            _db = db;
            table = _db.Set<T>();
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

        /// <summary>
        /// Bir tabloda aradığımız kriterleri sağlayan bir veri olup olmadığını kontrol etmemizi sağlayan metot.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns>bool type value</returns>
        public bool Any(Expression<Func<T, bool>> exp)
        {
            return table.Any(exp);
        }

        /// <summary>
        /// Bir tablodaki satır sayısını elde etmemizi sağlayan metot.
        /// </summary>
        /// <returns>Integer type value</returns>
        public int Count()
        {
            return table.Count();
        }

        /// <summary>
        /// Soft Delete yapmamızı sağlayan metot
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            T entity = GetById(id);
            entity.Status = DataStatus.Deleted;
            entity.UpdatedDateTime = DateTime.Now;

            table.Update(entity);
            Save();
        }

        /// <summary>
        /// Halihazırda veri tabanı üzerine aktif, yani silinmemiş, durumda olan verileri elde etmemizi sağlayan metot.
        /// </summary>
        /// <returns>List<T></returns>
        public List<T> GetActiveData()
        {
            return table
                .Where(x => x.Status != DataStatus.Deleted)
                .ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<T> GetAll()
        {
            return table.ToList();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        /// <summary>
        /// Tablo üzerinde, "id" değeri ile veri aramamızı sağlayan metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T type value</returns>
        public T GetById(int id)
        {
            return table.Find(id);
        }

        public List<T> SelectActivesByLimit(int limit)
        {
            return table
                .Where(x => x.Status != DataStatus.Deleted)
                .Take(limit)
                .ToList();
        }

        /// <summary>
        /// Hard delete
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SpecialDelete(int id)
        {
            T entity = GetById(id);
            table.Remove(entity);
            Save();
        }

        public void Update(T entity)
        {
            entity.Status = DataStatus.Updated;
            entity.UpdatedDateTime = DateTime.Now;
            table.Update(entity);
            Save();
        }

        public T Default(Expression<Func<T, bool>> exp)
        {
            return table.FirstOrDefault(exp);
        }
    }
}
