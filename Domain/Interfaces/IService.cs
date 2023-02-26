using Domain.Entities;


namespace Domain.Interfaces
{
    public interface IService<T, ID> where T : EntityBase
    {
        T Create(T entity);
        T Update(ID id, T entity);
        void Delete(ID id);
        List<T> GetAll();
        T GetById(ID id);
    }
}
