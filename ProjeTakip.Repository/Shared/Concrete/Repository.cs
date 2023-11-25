using Microsoft.EntityFrameworkCore;
using ProjeTakip.Data;
using ProjeTakip.Models;
using ProjeTakip.Repository.Shared.Abstract;
using System.Linq.Expressions;

namespace ProjeTakip.Repository.Shared.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _dbSet.Update(entity);

        }

        public void DeleteById(int id)
        {
            T entity = _dbSet.Find(id);
            entity.IsDeleted = true;
            entity.ModifiedDate= DateTime.Now;
            _dbSet.Update(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted == false);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return GetAll().Where(filter);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(x => x.IsDeleted == false).FirstOrDefault(filter);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entity.ModifiedDate=DateTime.Now;
            _dbSet.Update(entity);
        }
    }
}
