using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<ID, T> where T : EntityBase
    {
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(ID id);
    }
}
