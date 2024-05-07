using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;

namespace Controle_De_GastosAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public RepositoryPatternContext _dbcontext;
        DbSet<T> set;
        public Repository(RepositoryPatternContext dbcontext)
        {
            set = dbcontext.Set<T>();
            _dbcontext = dbcontext;
        }

        public void Add(T entity)
        {
            set.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(T entity)
        {
            set.Remove(entity);
            _dbcontext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return set.ToList();
        }

        public T GetById(int id)
        {
            return set.Find(id);
        }

        public void Update(T entity)
        {
            set.Update(entity);
            _dbcontext.SaveChanges();
        }
    }
}
