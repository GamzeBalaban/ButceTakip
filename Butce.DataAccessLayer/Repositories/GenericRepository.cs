using Butce.DataAccessLayer.Abstract;
using Butce.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly BudgetContext _context;

        public GenericRepository(BudgetContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetByID(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity == null)
            {
               
                throw new KeyNotFoundException($"ID'si {id} olan bir {typeof(T).Name} bulunamadı.");
            }
            return entity;
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
