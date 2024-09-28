using Microsoft.EntityFrameworkCore;
using News.BLL.InterFaces;
using News.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.BLL.Repositories
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _Context;

        public GenaricRepository(ApplicationDbContext context)
        {
            _Context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _Context.Set<T>().AsNoTracking().ToList();
        }

        public T? GetSpacific(int? id)
        {
            return _Context.Set<T>().FirstOrDefault(d => d.Id == id);
        }
        public int Add(T entity)
        {
            _Context.Set<T>().Add(entity);
            return _Context.SaveChanges();
        }

        public int Update(T entity)
        {
            _Context.Set<T>().Update(entity);
            return _Context.SaveChanges();
        }
        public int Delete(T entity)
        {
            _Context.Set<T>().Remove(entity);
            return _Context.SaveChanges();
        }

        public int DeletebYiD(int? id)
        {
            var result = _Context.Set<T>().FirstOrDefault(d => d.Id == id);
            _Context.Set<T>().Remove(result);
            return _Context.SaveChanges();
        }
    }
}
