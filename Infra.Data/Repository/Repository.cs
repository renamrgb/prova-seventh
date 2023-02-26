using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;


namespace Infra.Data.Repository
{
    public class Repository<ID, T> : IRepository<ID, T> where T : EntityBase
    {
        protected readonly SqlServerContext _sqlServerContext;

        public Repository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Delete(T entity)
        {
            _sqlServerContext.Set<T>().Remove(entity);
            _sqlServerContext.SaveChanges();
        }

        public List<T> GetAll() => _sqlServerContext.Set<T>().ToList();

        public T GetById(ID id) => _sqlServerContext.Set<T>().Find(id);

        public T Insert(T entity)
        {
            _sqlServerContext.Set<T>().Add(entity);
            _sqlServerContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            _sqlServerContext.Set<T>().Update(entity);
            _sqlServerContext.SaveChanges();
            return entity;
        }
    }
}
